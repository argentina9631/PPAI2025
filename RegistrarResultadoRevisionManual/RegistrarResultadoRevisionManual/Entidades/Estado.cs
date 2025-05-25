namespace RegistrarResultadoRevisionManual.Entidades
{
    public class Estado
    {
        private string Nombre { get; set; }
        private string Ambito { get; set; }

        public Estado(string nombre, string ambito)
        {
            Nombre = nombre;
            Ambito = ambito;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getAmbito()
        {
            return Ambito;
        }

        // Métodos específicos para nombres
        public bool esAutoDetectado()
        {
            return Nombre == "AutoDetectado";
        }

        public bool esBloqueado()
        {
            return Nombre == "Bloqueado";
        }

        // Método genérico para comparar nombre
        public bool esNombre(string nombre)
        {
            return Nombre == nombre;
        }

        // Métodos específicos para ámbito
        public bool esAmbitoEventoSismico()
        {
            return Ambito == "EventoSismico";
        }

        // Método genérico para comparar ámbito
        public bool esAmbito(string ambito)
        {
            return Ambito == ambito;
        }
    }
}
