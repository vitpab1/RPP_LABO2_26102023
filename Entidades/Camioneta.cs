using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;
        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion)
        {
            this.esAWD = true; 
            this.cabinaSimple = cabinaSimple;   
        }

        protected override string Tipo
        {
            get { return "Camioneta"; }
        }
        protected override string GetInfo()
        {
            StringBuilder infoBuilder = new StringBuilder(base.GetInfo());

            infoBuilder.Append(", con cabina: ");
            infoBuilder.Append(cabinaSimple ? "Doble (false)" : "Simple (true)");

            return infoBuilder.ToString();
        }

    }
}
