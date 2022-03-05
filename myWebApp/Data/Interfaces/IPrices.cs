using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Interfaces
{
    public interface IPrices
    {
        IEnumerable<Prices> AllPrices { get; }
    }
}
