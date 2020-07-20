using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University_Info.Models;
using University_Info.Gateway;

namespace University_Info.GatewayManager
{
    public class gatewayManager
    {
        StudentGateway studentgateway = new StudentGateway();
        public List<Student> GetStudentGetStudentInfo()
        {
            return studentgateway.GetStudentInfo();
        }
        public List<Department> GetDepartments()
        {
            return studentgateway.Getdepartment();

        }
    }
}
