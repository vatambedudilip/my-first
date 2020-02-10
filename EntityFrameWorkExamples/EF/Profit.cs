using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamples.EF
{
   public class Profit
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public string Year { get; set; }
        public string MonthInString { get; set; }
        public decimal ProfitAmount { get; set; }
    }
}
