using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorsAnalysis.Utils
{
    class OpenFileUtil
    {
        /// <summary>
        /// 获取当前文件路径
        /// </summary>
        /// <returns>当前文件路径</returns>
        public string OpenFile()
        {
            string foldPath = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "全部文件(*.*)|*.*";

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = Path.GetDirectoryName(fileDialog.FileName) + @"\" + Path.GetFileName(fileDialog.FileName);
                
            }
            return foldPath;
        }

    }
}
