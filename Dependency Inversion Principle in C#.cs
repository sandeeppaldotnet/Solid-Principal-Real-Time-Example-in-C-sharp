using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_Real_Time_Example_in_C_sharp
{
    internal class Dependency_Inversion_Principle_in_C_
    {
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }
        public class EmployeeBusinessLogic
        {
            IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;
            public EmployeeBusinessLogic()
            {
                _IEmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
            }
            public Employee GetEmployeeDetails(int id)
            {
                return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
            }
        }
        public interface IEmployeeDataAccessLogic
        {
            Employee GetEmployeeDetails(int id);
            //Any Other Employee Related Method Declarations
        }
        public class EmployeeDataAccessLogic : IEmployeeDataAccessLogic
        {
            public Employee GetEmployeeDetails(int id)
            {
                //In real time get the employee details from database
                //but here we have hard coded the employee details
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
            public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
            {
                return new EmployeeDataAccessLogic();
            }
        }
        
    }
}
