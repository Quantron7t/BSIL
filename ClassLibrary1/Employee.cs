using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Employee
    {
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public int Salary { get => salary; set => salary = value; }
        public char Grade { get => grade; set => grade = value; }

        private char grade;
        private int salary;
        private string location;
        private int id;
        private string name;
    }
}
