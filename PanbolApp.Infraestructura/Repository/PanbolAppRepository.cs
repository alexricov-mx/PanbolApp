using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanbolApp.Core.Dto;
using PanbolApp.Core.Interfaces.Repository;

namespace PanbolApp.Infraestructura.Repository
{
    public class PanbolAppRepository:BaseCloudFirebaseRepository,IPanbolAppRepository
    {
        public PanbolAppRepository(string connFirebase,string firebaseApiKey,string firebaseUser,string firebasePwd) : base(connFirebase, firebaseApiKey,firebaseUser,firebasePwd)
        {
        }

        public Task<GamerCard> GetGamers()
        {
            
            return null;


        }
    }
}
