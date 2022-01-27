using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Shifts
{
    public partial class Shift
    {
        public Shift (DateTime startTime, DateTime endTime, bool onlyWorkDays) : base()
        {
            StartTime = startTime;
            EndTime = endTime;
            OnlyWorkDays = onlyWorkDays;

        }

        public bool ValidOnAdd()
        {
            return true;
        }
    }
}
