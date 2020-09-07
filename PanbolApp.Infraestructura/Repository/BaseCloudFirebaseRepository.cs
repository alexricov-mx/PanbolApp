using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace PanbolApp.Infraestructura.Repository
{
    public class BaseCloudFirebaseRepository
    {
        private readonly string _connFirebase;
        private readonly string _firebaseApiKey;
        private readonly string _firebaseUser;
        private readonly string _firebasePwd;

        public BaseCloudFirebaseRepository(string connFirebase,string firebaseApiKey,string firebaseUser,string firebasePwd)
        {
            _connFirebase = connFirebase;
            _firebaseApiKey = firebaseApiKey;
            _firebaseUser = firebaseUser;
            _firebasePwd = firebasePwd;
        }

        public string GetConn()
        {
            

            return "";
        }

        public string GetApi()
        {
            return _firebaseApiKey;
        }

        public string GetUser()
        {
            return _firebaseUser;
        }

        public string GetPwd()
        {
            return _firebasePwd;
        }
    }
}
