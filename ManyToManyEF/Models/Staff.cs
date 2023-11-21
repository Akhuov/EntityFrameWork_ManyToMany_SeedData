﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyEF.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string     Name { get; set; }
        public ICollection<User>  Users { get; set; }   

    }
}
