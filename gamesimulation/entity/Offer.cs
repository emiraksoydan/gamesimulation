﻿using gamesimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesimulation.entity
{
    public class Offer : IEntity
    {
        public int ID { get; set; } 
        public string Name { get; set; }
    }
}
