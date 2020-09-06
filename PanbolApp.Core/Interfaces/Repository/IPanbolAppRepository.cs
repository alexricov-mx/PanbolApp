using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PanbolApp.Core.Dto;

namespace PanbolApp.Core.Interfaces.Repository
{
    public interface IPanbolAppRepository
    {
        Task<IEnumerable<GamerCard>> GetGamers();
    }
}
