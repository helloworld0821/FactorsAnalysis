using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsAnalysis.Model
{
    class ResultModel
    {
        //public int 序号 { set; get; }
        public string 油井 { set; get; }
        public int 层位 { set; get; }
        public double 产液 { set; get; }
        public double 含水 { set; get; }
        public string 水井 { set; get; }
        //public double 注入量 { set; get; }


        public double 井距 { set; get; }
        public decimal 平均剩余储量 { set; get; }
        public decimal 平均圧力 { set; get; }
        public decimal 平均含油饱和度 { set; get; }
        public decimal 平均渗透率 { set; get; }
        public decimal 平均地层系数 { set; get; }
        public decimal 注采压差 { set; get; }
        public decimal 平均孔隙度 { set; get; }
    }
}
