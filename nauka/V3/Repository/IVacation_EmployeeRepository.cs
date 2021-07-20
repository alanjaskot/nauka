using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Repository
{
    public interface IVacation_EmployeeRepository
    {
        public bool Add(Vacation_Employee vacationOfEmployee);

        public bool Delete(Vacation_Employee vacationOfEmployee);

        public Vacation_Employee GetVacationOfEmployee(Guid vacationId, Guid employeeId);

        public List<Vacation_Employee> GetVacationOfEmployees();
    }
}
