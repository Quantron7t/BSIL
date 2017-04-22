using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace BusinessLayer
{
    public class EmployeeData : IManageEmployee
    {
        public void Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int employeeId)
        {
            AdoAccess aA = new AdoAccess();
            aA.Delete(employeeId);
        }

        public List<Employee> Read()
        {
            AdoAccess aA = new AdoAccess();
            return aA.Read();
        }

        public Employee ReadById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
