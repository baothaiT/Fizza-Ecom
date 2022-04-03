using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Thinh_Ecom.Entities
{
    public class CommentInproduct
    {
        public Comment ReviewsRIP { get; set; }
        public string rip_ReviewId { get; set; }
        public Products ProductsRIP { get; set; }
        public string rip_ProductId { get; set; }


    }
}
