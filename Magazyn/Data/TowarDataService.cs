using Magazyn.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Magazyn.Data
{
    public class TowarDataService
    {
        List<Tbtowar> TowareList = new List<Tbtowar>()
        {

        };
        public async Task<IEnumerable<Tbtowar>> TowarList()

        {
            return await Task.FromResult(TowareList);
        }
    }
}
