using FactorsAnalysis.DAL;
using FactorsAnalysis.Model;
using FactorsAnalysis.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FactorsAnalysis
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtOil = new DataTable();
        DataTable dtWater = new DataTable();
        DataTable dtResult = new DataTable();

        string strDate = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFA_Click(object sender, EventArgs e)
        {
            OpenFileUtil ofu = new OpenFileUtil();
            txtFAPath.Text = ofu.OpenFile();
        }

        private void btnOpenLTK_Click(object sender, EventArgs e)
        {
            txtLTKPath.Text = FileDialogHelper.OpenExcel();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("正在处理数据");
            splashScreenManager1.SetWaitFormDescription("请稍后...");

            //FileStream fs = new FileStream(txtResultPath.Text, FileMode.Append);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("油井 层位 产液 含水 水井 注水 井距 注采压差  平均圧力 平均含油饱和度 平均储量 平均渗透率 平均地层系数");

            ReadFilesDAL.ReadFiles(txtFAPath.Text);
            FactorsAnalysisDAL fad = new FactorsAnalysisDAL();
            DataTable dtLtjh = ExcelToDataTableUtil.ExcelToDataTable(txtLTKPath.Text);
            for (int i = 0; i < dtLtjh.Rows.Count; i++)
            {

                DataRow[] drJHY = dtOil.Select("JHY = '" + dtLtjh.Rows[i]["JHY"] + "' AND DATE = '" + strDate + "'");
                if (drJHY.Count() > 0)
                {

                    foreach (DataRow dr in drJHY)
                    {
                        //DataTable dtLtjhy = dtLtjh.Select("JHS = '" + dtLtjh.Rows[i]["JHS"] + "'").CopyToDataTable();

                        //DataRow[] drJHS = dtWater.Select("JHS = '" + dtLtjh.Rows[i]["JHS"] + "' AND K = " + dr["K"] + " AND DATE = '" + strDate + "'");
                        DataRow[] drJHS = dtWater.Select("JHS = '" + dtLtjh.Rows[i]["JHS"] + "' AND DATE = '" + strDate + "'");
                        if (drJHS.Count() > 0)
                        {
                            //for (int j = 0; j < dtLtjhy.Rows.Count; j++)
                            //{
                            //DataRow[] drOthrJHY = dtOil.Select("JHY = '" + dtLtjhy.Rows[j]["JHY"] + "' AND K = " + dr["K"] + " AND DATE = '" + strDate + "'");
                            //if (drOthrJHY.Count() > 0)
                            //{
                            //foreach (DataRow drOthr in drOthrJHY)
                            //{

                            WellModel jhy = new WellModel();
                            //jhy.x = Convert.ToInt32(drOthr["X"]);
                            //jhy.y = Convert.ToInt32(drOthr["Y"]);
                            //jhy.k = Convert.ToInt32(drOthr["K"]);
                            //DataRow[] drMNCYE = dtOil.Select("JHY = '" + drOthr["JHY"] + "' AND DATE = '" + strDate + "' AND K = " + dr["k"]);
                            jhy.x = Convert.ToInt32(dr["X"]);
                            jhy.y = Convert.ToInt32(dr["Y"]);
                            jhy.k = Convert.ToInt32(dr["K"]);
                            jhy.mncye = Convert.ToDouble(dr["MNCYE"]);
                            WellModel jhs = new WellModel();
                            jhs.x = Convert.ToInt32(drJHS[0]["X"]);
                            jhs.y = Convert.ToInt32(drJHS[0]["Y"]);
                            //jhs.k = Convert.ToInt32(drJHS[0]["K"]);
                            jhs.k = Convert.ToInt32(dr["K"]);
                            //DataRow[] drMNCS = dtWater.Select("JHS = '" + dtLtjh.Rows[i]["JHS"] + "' AND DATE = '" + strDate + "' AND K = " + dr["k"]);
                            InfFactorModel ifm = new InfFactorModel();

                            ifm = fad.InfluencingFactors(jhy, jhs, ReadFilesDAL.lstPressure, ReadFilesDAL.lstSoil, ReadFilesDAL.lstFipoil, ReadFilesDAL.lstKX, ReadFilesDAL.lstDCXS, ReadFilesDAL.lstPORO);

                            DataRow drResult = dtResult.NewRow();
                            //drResult["序号"] = i + 1;
                            drResult["油井"] = dr["JHY"];
                            drResult["层位"] = dr["k"];
                            drResult["产液"] = dr["MNCYE"];
                            drResult["含水"] = dr["HS"];
                            drResult["水井"] = drJHS[0]["JHS"];
                            //drResult["注入量"] = drMNCS[0]["MNCS"];
                            drResult["井距"] = ifm.wellSpacing;
                            drResult["注采压差"] = ifm.presDiff;
                            drResult["平均圧力"] = ifm.presAverage;
                            drResult["平均含油饱和度"] = ifm.soilAverage;
                            drResult["平均剩余储量"] = ifm.fipoilAverage;
                            drResult["平均渗透率"] = ifm.kxAverage;
                            drResult["平均地层系数"] = ifm.dcxsAverage;
                            drResult["平均孔隙度"] = ifm.poroAverage;
                            dtResult.Rows.Add(drResult);
                            //    }
                            //}
                            //}
                        }
                    }
                }
                //sw.WriteLine("---------------------------------------------------------------------");
            }
            gridResult.DataSource = dtResult;

            DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
            gridResult.ExportToXls(txtResultPath.Text);

            //sw.Close();
            //fs.Close();
            splashScreenManager1.CloseWaitForm();

            DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridResult.Visible = false;
            ReadFilesDAL.ReadPermX();
            ReadFilesDAL.ReadDZ();
            ReadFilesDAL.ReadPORO();
            ReadFilesDAL.CalcDCXS();

            WellModel wm = new WellModel();
            List<ResultModel> lstRM = new List<ResultModel>();
            List<WellModel> lstOil = new List<WellModel>();
            List<WellModel> lstWater = new List<WellModel>();
            ///List<WellModel> lstDY = new List<WellModel>();
            ListToDataTableUtil ltdu = new ListToDataTableUtil();
            dtResult = ltdu.ListToDataTable(lstRM);
            string[] sj = File.ReadAllLines("水.txt");
            for (int i = 0; i < sj.Count(); i++)
            {
                wm = new WellModel();
                string[] str = Regex.Split(sj[i], @"\s+");
                wm.jhs = str[0];
                wm.date = str[1];
                wm.x = Convert.ToInt32(str[2]);
                wm.y = Convert.ToInt32(str[3]);
                wm.k = Convert.ToInt32(str[4]);
                wm.mncs = Convert.ToDouble(str[5]);
                lstWater.Add(wm);
            }
            dtWater = ltdu.ListToDataTable(lstWater);
            string[] yj = File.ReadAllLines("油.txt");
            for (int i = 0; i < yj.Count(); i++)
            {
                wm = new WellModel();
                string[] str = Regex.Split(yj[i], @"\s+");
                wm.jhy = str[0];
                wm.date = str[1];
                wm.x = Convert.ToInt32(str[2]);
                wm.y = Convert.ToInt32(str[3]);
                wm.k = Convert.ToInt32(str[4]);
                wm.mncs = Convert.ToDouble(str[5]);
                wm.mncy = Convert.ToDouble(str[6]);
                wm.mncye = Convert.ToDouble(str[7]);
                wm.hs = Convert.ToDouble(str[8]);
                lstOil.Add(wm);
            }
            dtOil = ltdu.ListToDataTable(lstOil);
            DataTable dtDate = dtWater.DefaultView.ToTable(true, "date");
            for (int i = 0; i < dtDate.Rows.Count; i++)
            {
                cmbDate.Properties.Items.Add(dtDate.Rows[i]["date"]);
            }


        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            strDate = cmbDate.Text;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtResultPath.Text = FileDialogHelper.SaveExcel();
        }
    }
}
