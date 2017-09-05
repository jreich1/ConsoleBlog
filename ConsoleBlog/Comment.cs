﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Comment : IComment
    {
        public string Body { get; set; }
        public DateTime dateTime { get; set; }
        public Author Owner { get; set; }

        public Comment() { }

        public Comment(string body, Author owner, Post post)
        {
            Body = body;
            Owner = owner;
            this.dateTime = DateTime.Now;
            owner.MyComments.Add(this);
            post.Comments.Add(this);
        }
    }
}
