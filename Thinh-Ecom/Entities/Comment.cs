using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Thinh_Ecom.Entities
{
    public class Comment
    {
        public string Comment_id { set; get; }
        public string Comment_Content { set; get; }
        public AppUser AppUserR { get; set; }
        public string Comment_UserId { set; get; }
        public bool Comment_HideStatus { get; set; }
        public string Comment_ReviewType { get; set; }
        public List<CommentInproduct> ReviewInproductR { get; set; }

        public DateTime Comment_UploadTime { set; get; }

    }
}
