using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using University_Info.Models;

namespace University_Info.Gateway
{
    public class StudentGateway
    {
        public List<Student> GetStudentInfo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EF9DLAS;Initial Catalog=Studentmvc;Integrated Security=True");
            string querry = "SELECT * FROM details_info";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student();
                student.student_name = reader["student_name"].ToString();
                student.reg_no = reader["reg_no"].ToString();
                student.email = reader["email"].ToString();
                student.dept_name = reader["dept_name"].ToString();
                student.address = reader["address"].ToString();
                students.Add(student);



            }
            con.Close();
            return students;
        }
        public List<Department> Getdepartment() {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EF9DLAS;Initial Catalog=Studentmvc;Integrated Security=True");
            string querry = "SELECT * FROM dept_table";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Department> departments = new List<Department>();
            while (reader.Read())
            {
                Department department = new Department();
                department.id = (int)reader["id"];
                department.departmentName = reader["department_name"].ToString();
                department.dept_name = reader["dept_name"].ToString();
                departments.Add(department);



            }
            con.Close();
            return departments;

        }
    }
}
