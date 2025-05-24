namespace CapaEntidades
{
    public class TipoDeDato
    {
        public string Nombre { get; set; }

        public TipoDeDato(string nombre)
        {
            Nombre = nombre;
        }

        // 42–44 : getters específicos
        public double getVelocidadOnda(double valor)
        {
            return Nombre == "Velocidad" ? valor : 0;
        }

        public double getFrecuenciaOnda(double valor)
        {
            return Nombre == "Frecuencia" ? valor : 0;
        }

        public double getLongitudOnda(double valor)
        {
            return Nombre == "Longitud" ? valor : 0;
        }
    }
}
