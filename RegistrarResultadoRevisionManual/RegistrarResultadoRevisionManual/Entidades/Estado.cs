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

        // Métodos específicos para nombres de estado
        //
        //
        public bool esAutoDetectado()
        {
            return Nombre == "AutoDetectado";
        }

        public bool esBloqueado()
        {
            return Nombre == "Bloqueado";
        }

        public bool esRechazado()
        {
            return Nombre == "Rechazado";
        }


        // Métodos específicos para ámbitos
        //
        //
        public bool esAmbitoEventoSismico()
        {
            return Ambito == "EventoSismico";
        }

    }
}
