using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IEmpleado : IGenericRepository<Empleado>
    {
        Task<IEnumerable<Empleado>> EmployeesWhoHaventMadeSales();
        Task<IEnumerable<Empleado>> EmployeesWhoHaveLessThan5Sales();
        Task<Empleado> EmployeeWhoSoldMoreKindOfDrugsBetween(DateTime firtsDate, DateTime lastDate);
        Task<List<Empleado>> EmployeesWhoDidntSellBetween(DateTime firtsDate, DateTime lastDate);
    }
}