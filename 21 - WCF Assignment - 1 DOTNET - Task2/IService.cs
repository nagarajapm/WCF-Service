using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _21___WCF_Assignment___1_DOTNET___Task2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        List<string> OpeningJobs();

        [OperationContract]
        List<string> OpeningJobsByRole(string Role);

        // TODO: Add your service operations here
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Roles
    {
        string pRoleName = "";
        string pJobName = "";
        [DataMember]
        public string RoleName
        {
            get
            {
                return pRoleName;
            }
            set
            {
                pRoleName = value;
            }
        }

        [DataMember]
        public string JobName
        {
            get
            {
                return pJobName;
            }
            set
            {
                pJobName = value;
            }
        }
    }
}
