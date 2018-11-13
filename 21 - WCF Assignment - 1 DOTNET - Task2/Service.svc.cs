using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _21___WCF_Assignment___1_DOTNET___Task2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public List<string> OpeningJobs()
        {
            List<string> pRoles = GetJobs("");
            return pRoles;
        }

        public List<string> OpeningJobsByRole(string Role)
        {
            List<string> pRoles = GetJobs(Role);
            return pRoles;
        }

        private List<Roles> ListofRoles()
        {
            List<Roles> pRoles = new List<Roles>();

            Roles pRole3 = new Roles();
            pRole3.JobName = "Trainee";
            pRole3.RoleName = "User";
            pRoles.Add(pRole3);

            Roles pRole4 = new Roles();
            pRole4.JobName = "Programmer Analyst";
            pRole4.RoleName = "Admin";
            pRoles.Add(pRole4);


            Roles pRole1 = new Roles();
            pRole1.JobName = "Associate";
            pRole1.RoleName = "Admin";
            pRoles.Add(pRole1);

            Roles pRole2 = new Roles();
            pRole2.JobName = "Senior Associate";
            pRole2.RoleName = "Super Admin";
            pRoles.Add(pRole2);


            Roles pRole5 = new Roles();
            pRole5.JobName = "Manager";
            pRole5.RoleName = "Super Admin";
            pRoles.Add(pRole1);
            return pRoles;
        }
        private List<string> GetJobs(string role)
        {
            List<Roles> proles = ListofRoles();
            List<string> jobs = new List<string>();
            if (role != "")
            {
                jobs = (from Role in proles
                        where Role.RoleName == role
                        select Role.JobName).ToList();
            }
            else
            {
                jobs = (from Role in proles
                        select Role.JobName).ToList();
            }
            return jobs;
        }
    }
}
