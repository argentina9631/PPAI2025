namespace RegistrarResultadoRevisionManual.Entidades
{
    public class Estado
    {
        //
        // ATRIBUTOS
        //
        private string Nombre { get; set; }
        private string Ambito { get; set; }


        //
        // CONSTRUCTOR
        //
        public Estado(string nombre, string ambito)
        {
            Nombre = nombre;
            Ambito = ambito;
        }


        // 
        // METODOS
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

        public bool esAmbitoEventoSismico()
        {
            return Ambito == "EventoSismico";
        }

    }
}
