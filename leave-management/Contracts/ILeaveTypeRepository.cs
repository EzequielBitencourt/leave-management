using leave_management.Contracts;
using leave_management.Data;
using System.Collections.Generic;

namespace leave_management.Repository
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
