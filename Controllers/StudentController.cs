using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using University_Info.Models;
using University_Info.GatewayManager;
using University_Info.Gateway;
namespace University_Info.Controllers
    
{
    public class StudentController : Controller
    {
        public ActionResult Savestudent()
        {
           gatewayManager gManager = new gatewayManager();
            ViewBag.vb = gManager.GetDepartments();
            ViewBag.gatewayview = gManager.GetStudentGetStudentInfo();
            return View();
        
        }
        [HttpPost]
        public ActionResult Savestudent(Student student)
        {
            string msg="";
            if (ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-EF9DLAS;Initial Catalog=Studentmvc;Integrated Security=True");
                con.Open();
                string querry = "INSERT INTO student_table (student_name,reg_no,email,address,dept_id) VALUES('" + student.student_name + "','" + student.reg_no + "','" + student.email + "','" + student.address + "','" + student.dept_name + "')";
                SqlCommand cmd = new SqlCommand(querry, con);
                int rowcount = cmd.ExecuteNonQuery();
                if (rowcount > 0)
                {

                    msg = "successfully added on database . ";
                }
                else { msg = "not saved."; }

            }
            gatewayManager gManager = new gatewayManager();
            ViewBag.vb = gManager.GetDepartments();
            
            ViewBag.gatewayview = gManager.GetStudentGetStudentInfo();
            ViewBag.viewbag = msg;
            return View();
        }
        public ActionResult Index()
        {
            //ViewBag.message = "this is view bag.";
            Student student = new Student();
            student.student_name = "Fahim";
            student.reg_no = "1710";
            ViewBag.info = student;
            return View();
        }
        public ActionResult Getall()
        {
            //ViewBag.studen = Students();
            return View(Students());
        }
        public List<string> Getdepartment()
        {
            return new List<string>
            {
                "cse","ete","msj","eee","eng","bba"
            };
        }
        public List<Student>Students()
        {

           
            return new List<Student>
            {
                new Student{student_name ="Fahim",email="f@gmail.com",reg_no="1710",address="Dhaka",dept_name="cse" },
                new Student{student_name ="Maliha",email="M@gmail.com",reg_no="1731",address="Dhaka",dept_name="EEE" }



            };
        }
    }
}