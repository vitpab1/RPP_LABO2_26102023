﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo

    {
        public Automovil(EPropulsion propulsion) : base(propulsion)
        {
            propulsion = EPropulsion.Hibrida; 

        }
        protected override string Tipo
        {
            get { return "Automovil"; }
        }
    }
}
