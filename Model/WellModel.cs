using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsAnalysis.Model
{
    class WellModel
    {
        /// <summary>
        /// 油井坐标信息
        /// mncy - 模拟产油
        /// sumcy - 模拟分层产油求和
        /// mncs - 模拟产水
        /// sumcs - 模拟分层产水求和
        /// cye - 产液
        /// sumcye - 模拟分层产液求和
        /// 
        /// </summary>
        public string jhy { set; get; }
        public int k { set; get; }
        public double mncye { set; get; }
        public double hs { set; get; }
        public string jhs { set; get; }
        public double mncs { set; get; }
        

        public double wellSpacing { set; get; }
        public decimal fipoilAverage { set; get; }
        public decimal presAverage { set; get; }
        public decimal soilAverage { set; get; }
        public decimal kxAverage { set; get; }
        public decimal dcxsAverage { set; get; }
        public decimal presDiff { set; get; }
        public decimal poroAverage { set; get; }
        public string date { set; get; }
        public int x { set; get; }
        public int y { set; get; }
       
        public double mncy { set; get; }



        
    }
}
