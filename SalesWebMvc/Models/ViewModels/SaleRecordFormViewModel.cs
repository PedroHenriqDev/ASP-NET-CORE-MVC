using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Models.ViewModels
{
    public class SaleRecordFormViewModel
    {
        public SalesRecord SalesRecord { get; set; }
        public IEnumerable<Seller> Sellers { get; set; }
    }
}
