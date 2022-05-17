using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    public  struct DayTime
    {
        private long Minutes;

        public DayTime(long minutes)
        {
            this.Minutes = minutes;
        }
        public static DayTime operator +(DayTime lhs, int minutes)
        {
            return Utils.Now;
        }
        public override string ToString()
        {
            return "";
        }
    }

}
