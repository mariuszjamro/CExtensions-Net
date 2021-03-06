﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.Test.Model
{
    public class Post
    {

        public Post()
        {
            Comments = new List<Comment>();
        }

        public Int64 Id { get; set; } // Post_Id (Primary key)
        public string Subject { get; set; } // Subject
        public string Body { get; set; } // Body
        public DateTime? DateCreated { get; set; } // DateCreated
        public DateTime? DateModified { get; set; } // DateModified
        public Int64 AutId { get; set; } // AUT_ID

        // Foreign keys
        public virtual Author Author { get; set; } // FK_POST_AUTHOR

        public virtual ICollection<Comment> Comments { get; set; } // POST.FK_POST_COMMENT
    }
}
