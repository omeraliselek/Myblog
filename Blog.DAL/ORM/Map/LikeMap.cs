using Blog.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.Map
{
   public  class LikeMap:CoreMap<Like>
    {

        public LikeMap()
        {
            ToTable("dbo.Likes");

            HasKey(c => new { c.AppUserID, c.ArticleID });

        }
    }
}
