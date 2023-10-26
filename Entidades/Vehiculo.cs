namespace Entidades
{
    public abstract class Vehiculo
    {

        protected bool esAWD;
        protected Guid numeroDeChasis;
        private EPropulsion propulsion;



        public enum EPropulsion
        {
            Combustion,
            Hibrida,
            Electrica
        }

        public EPropulsion Propulsion
        {
            get { return propulsion; }
        }

        protected abstract string Tipo
        {
            get;
        }

        protected virtual string GetInfo()
        {
            string tipo = Tipo; 
            string propulsion = Propulsion.ToString(); 
            Guid numeroDeChasis = Guid.NewGuid(); 

            string formato = "[{0}] con propulsión a {1}, {2} es AWD, número de chasis {3}";
            return string.Format(formato, tipo, propulsion, esAWD ? "SI" : "NO", numeroDeChasis);
        }


        
        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            if (Equals(v1, v2) && v1.numeroDeChasis == v2.numeroDeChasis)
            {
                return true;
            }
            return false;
        }
       
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


        protected Vehiculo(EPropulsion propulsion)
        {
            this.propulsion = propulsion;
        }
        protected Vehiculo(EPropulsion propulsion, bool esAWD = false)
        {
            this.propulsion = propulsion;
            this.esAWD = esAWD;
        }

        public override string ToString()
        {
            return GetInfo(); 
        }
    }
}