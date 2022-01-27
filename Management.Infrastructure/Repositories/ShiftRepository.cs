using Management.Domain.Shifts;
using System;

namespace Management.Infrastructure.Repositories
{
    public class ShiftRepository : Repository<Shift>, IShiftRepository
    {
        public ShiftRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public Shift NewShift(DateTime startTime, DateTime endTime, bool onlyWorkDay)
        {
            var shift = new Shift(startTime, endTime, onlyWorkDay);
            if (shift.ValidOnAdd())
            {
                this.Add(shift);
                return shift;
            }
            else
                throw new Exception("shift invalid");
        }
    }
}
