namespace CapaEntidades
{
    public class EstacionSismologica
    {
        public string Codigo { get; set; }
        public string Ubicacion { get; set; }

        // 47 : getCodigoEstacion
        public string getCodigoEstacion()
        {
            return Codigo;
        }
    }
}
