using Magazyn.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Magazyn.Data
{
    public class UserDataService
    {
        List<Tbuser> UsereList = new List<Tbuser>()
        {

        };
         public async Task<IEnumerable<Tbuser>> UserList()

        {
            return await Task.FromResult(UsereList);
        }
    }
}
