﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610.Entities
{
    public class Automovil : Carro
    {
        
        public Carro Carro { get; set; }
        public TipoAuto TipoAuto { get; set; }
    }
}
