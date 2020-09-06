using System;
using System.Collections.Generic;
using System.Text;

namespace PanbolApp.Core.Dto
{
    public class GamerCard
    {
        public string GamerTag { get; set; }
        public string Correo { get; set; }
        public DateTime FAlta { get; set; }
        public string Imagen { get; set; }
        public bool IsAdmin { get; set; }

        public GamerCard(string gamertag, string correo, DateTime falta, string imagen, bool isAdmin)
        {
            GamerTag = gamertag;
            Correo = correo;
            FAlta = falta;
            Imagen = imagen;
            IsAdmin = isAdmin;
        }
    }
}
