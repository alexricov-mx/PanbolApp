using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using PanbolApp.Core.Dto;
using PanbolApp.Core.Interfaces.Repository;

namespace PanbolApp.Infraestructura.Repository
{
    public class PanbolAppRepository:BaseCloudFirebaseRepository,IPanbolAppRepository
    {
        public PanbolAppRepository(string connFirebase) : base(connFirebase)
        {
        }

        public async Task<IEnumerable<GamerCard>> GetGamers()
        {
            using (FirebaseClient firebase = this.GetConn())
            {
                var userList = await firebase
                    .Child("USUARIOS")
                    .OrderByKey()
                    .OnceAsync<GamerCard>();

                IEnumerable<GamerCard> resUsers = null;

                foreach (var user in userList)
                {
                    resUsers.Append(new GamerCard(
                        user.Object.GamerTag,
                        user.Object.Correo,
                        user.Object.FAlta,
                        user.Object.Imagen,
                        user.Object.IsAdmin));
                }

                return resUsers;
            }
        }
    }
}
