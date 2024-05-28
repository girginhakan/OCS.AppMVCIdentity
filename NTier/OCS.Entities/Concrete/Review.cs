﻿using OCS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.Entities.Concrete
{
    public class Review : BaseEntity
    {
        public int ProductId { get; set; }
        //public int AppUserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }


        //public AppUser AppUser{ get; set; }
        public Product Product { get; set; }



    }
}
