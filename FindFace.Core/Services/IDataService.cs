using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindFace.Core.Model;

namespace FindFace.Core.Services
{
   public interface IDataService
    {
        Task<List<ConfidenceFace>> GetDataFromService();

    }
}
