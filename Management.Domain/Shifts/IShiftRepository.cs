using Management.Domain.Interfaces;
using System;

namespace Management.Domain.Shifts
{
    public interface IShiftRepository : IRepository<Shift>
    {
        Shift NewShift(DateTime startTime, DateTime endTime, bool onlyWorkDay);
    }
}
