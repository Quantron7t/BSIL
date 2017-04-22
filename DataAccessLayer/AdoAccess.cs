using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class AdoAccess : IManageEmployee
    {
        SqlConnection sqlConnection;
        string connectionString = "Data Source=TRON-PC;Initial Catalog=BsilRetry;Integrated Security=True";
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        List<Employee> employeeList;

        public void Create(Employee employee)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                string createCommand = "Insert into employee values(@id,@name,@location,@salary,@grade)";
                sqlCommand = new SqlCommand(createCommand,sqlConnection);
                sqlCommand.Parameters.AddWithValue("id",employee.Id);
                sqlCommand.Parameters.AddWithValue("name", employee.Id);
                sqlCommand.Parameters.AddWithValue("location", employee.Id);
                sqlCommand.Parameters.AddWithValue("salary", employee.Id);
                sqlCommand.Parameters.AddWithValue("grade", employee.Id);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Delete(int employeeId)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                string deleteCommand = "delete from employee where id =@id";
                sqlCommand = new SqlCommand(deleteCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id",employeeId);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public List<Employee> Read()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                string readCommand="Select * from employee Order By id ASC";
                sqlCommand = new SqlCommand(readCommand,sqlConnection);
                employeeList = new List<Employee>();
                sqlConnection.Open();
                using (sqlDataReader=sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {                        
                        employeeList.Add(new Employee { Id=(int)sqlDataReader["id"],Name=sqlDataReader["name"].ToString(),Location=sqlDataReader["location"].ToString(),Salary=(int)sqlDataReader["salary"],Grade=sqlDataReader["grade"].ToString()[0]});
                    }
                }
            }
            return employeeList;
        }

        public Employee ReadById(int employeeId)
        {
            Employee employee = new Employee();

            using (sqlConnection = new SqlConnection(connectionString))
            {
                string readByIdCommand = "Select * from employee where id =@id";
                sqlCommand = new SqlCommand(readByIdCommand,sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id",employeeId);
                sqlConnection.Open();
                using (sqlDataReader = sqlCommand.ExecuteReader())
                {
                    employee.Id = (int)sqlDataReader["id"];
                    employee.Name = sqlDataReader["name"].ToString();
                    employee.Location = sqlDataReader["location"].ToString();
                    employee.Salary= (int)sqlDataReader["salary"];
                    employee.Grade= sqlDataReader["grade"].ToString()[0];
                }
            }
            return employee;
        }

        public void Update(Employee employee)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                string updateCommand = "update employee set name=@name,location=@location,salary=@salary,grade=@grade where id=@id";
                sqlCommand = new SqlCommand(updateCommand,sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", employee.Id);
                sqlCommand.Parameters.AddWithValue("name", employee.Id);
                sqlCommand.Parameters.AddWithValue("location", employee.Id);
                sqlCommand.Parameters.AddWithValue("salary", employee.Id);
                sqlCommand.Parameters.AddWithValue("grade", employee.Id);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
