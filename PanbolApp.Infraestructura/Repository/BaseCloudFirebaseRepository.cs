using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace PanbolApp.Infraestructura.Repository
{
    public class BaseCloudFirebaseRepository
    {
        private readonly string _connFirebase;

        public BaseCloudFirebaseRepository(string connFirebase)
        {
            _connFirebase = connFirebase;
        }

        public FirebaseClient GetConn()
        {
            return new FirebaseClient(_connFirebase);
        }
    }
}
