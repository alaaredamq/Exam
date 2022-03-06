using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Soap {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 {
        [OperationContract]
        DataSet UsersWithNoAccounts();

    }

    [DataContract]
    public class Users {
        int? id;
        string firstname = string.Empty;
        string lastname = string.Empty;
        string middlename= string.Empty;
        string dob= string.Empty;
        int? branchid;

        [DataMember]
        public int? Id {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Firstname {
            get { return firstname; }
            set { firstname = value; }
        }

        [DataMember]
        public string Lastname {
            get { return lastname; }
            set { lastname = value; }
        }

        [DataMember]
        public string Middlename {
            get { return middlename; }
            set { middlename = value; }
        }

        [DataMember]
        public string DOB {
            get { return dob; }
            set { dob = value; }
        }

        [DataMember]
        public int? BranchId {
            get { return branchid; }
            set { branchid = value; }
        }
    }

}
