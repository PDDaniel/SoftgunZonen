﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftgunZonen.Models
{
    public class CommentVM
    {
        public Comment Comment { get; set; }
        public Member Member { get; set; }
    }
}