using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nauka.V3.Repository
{
    public class Vacation_EmployeeRepository: IVacation_EmployeeRepository
    {
        DataBaseContext _context;

        public Vacation_EmployeeRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add(Vacation_Employee vacationOfEmployee)
        {
            var result = false;
            if(vacationOfEmployee != null)
            {
                _context.VacationOfEmployees.Add(vacationOfEmployee);
                result = true;
            }

            return result;
        }

        public bool Delete(Vacation_Employee vacationOfEmployee)
        {
            var result = false;
            if(vacationOfEmployee != null)
            {
                _context.VacationOfEmployees.Remove(vacationOfEmployee);
                result = true;
            }

            return result;
        }

        public Vacation_Employee GetVacationOfEmployee(Guid vacationId, Guid employeeId)
        {       
            return _context.VacationOfEmployees.Where(voe => voe.VacationId == vacationId && voe.EmployeeId == employeeId).FirstOrDefault();
        }

        public List<Vacation_Employee> GetVacationOfEmployees()
        {
            return _context.VacationOfEmployees.ToList();
        }
    }
}
