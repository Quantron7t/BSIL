using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public interface IManageEmployee
    {
        void Create(Employee employee);
        List<Employee> Read();
        Employee ReadById(int employeeId);
        void Update(Employee employee);
        void Delete(int employeeId);
    }
}
