﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MobileTrader.Entity
{
    
    public class Make
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual  ICollection<Model> Models { get; set; }
        
        public Make()
        {
            Models = new Collection<Model>();
        }

    }
}