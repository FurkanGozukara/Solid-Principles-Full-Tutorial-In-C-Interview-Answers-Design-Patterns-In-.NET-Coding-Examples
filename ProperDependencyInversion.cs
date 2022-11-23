using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static solid_design_principles.DependencyInversionViolation;

namespace solid_design_principles
{
    internal class ProperDependencyInversion
    {
        public interface IEmployeeDataAccess
        {
            Employee GetEmployeeDetails(int id);
        }

        public class EmployeeDataAccess : IEmployeeDataAccess
        {
            public Employee GetEmployeeDetails(int id)
            {
                // In real time get the employee details from db
                //but here we are hardcoded the employee details
                Employee emp = new Employee()
                {
                    ID = id,
                    Name = "Pranaya",
                    Department = "IT",
                    Salary = 10000
                };
                return emp;
            }
        }

        public class DataAccessFactory
        {
            public static IEmployeeDataAccess GetEmployeeDataAccessObj()
            {
                return new EmployeeDataAccess();
            }
        }

        public class EmployeeBusinessLogic
        {
            IEmployeeDataAccess _EmployeeDataAccess;
            public EmployeeBusinessLogic()
            {
                _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
            }
            public Employee GetEmployeeDetails(int id)
            {
                return _EmployeeDataAccess.GetEmployeeDetails(id);
            }
        }
    }
}
