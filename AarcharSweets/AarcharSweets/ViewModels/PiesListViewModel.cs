using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AarcharSweets.Models;

namespace AarcharSweets.ViewModels
{
    public class PiesListViewModel
    {
        public string CurrentCategory { get; set; }

        public IEnumerable<Pie> Pies { get; set; }
    }
}
