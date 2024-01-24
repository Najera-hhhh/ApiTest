using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PaginationProducts
    {

            public List<Product>? products { get; set; }
            public int total { get; set; }
            public int skip { get; set; }
            public int limit { get; set; }
        
    }
}
