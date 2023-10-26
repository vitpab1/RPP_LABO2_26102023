using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

    

    
        private Fabrica()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad)
        {
            this.capacidad = capacidad;
            vehiculos = new List<Vehiculo>();

        }

        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {

            if (fabrica.vehiculos.Count < fabrica.capacidad) {

                fabrica.vehiculos.Add(vehiculo);

            }
            return fabrica; 

        }
        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        { 
            
           Vehiculo vehiculoEliminar = fabrica.vehiculos.FirstOrDefault(v => v.GetType() == vehiculo.GetType() && v.ToString() == vehiculo.ToString());
            if (vehiculoEliminar != null)
            {
                fabrica.vehiculos.Remove(vehiculoEliminar);
            }
            return fabrica;
        }



    }
}
