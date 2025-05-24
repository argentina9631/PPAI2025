namespace CapaEntidades
{
    public class Estado
    {
        public string Nombre { get; set; } // Nombre del estado, ej: "AutoDetectado", "Bloqueado", "Rechazado"

        public Estado(string nombre)
        {
            Nombre = nombre;
        }

        // 29 / 31 / 34 : getNombre
        public string getNombre()
        {
            // Devuelve el nombre del estado
            return Nombre;
        }

        // 18 / 62 : esBloqueado, esRechazado
        public bool esBloqueado()
        {
            return Nombre == "Bloqueado";
        }

        public bool esRechazado()
        {
            return Nombre == "Rechazado";
        }
    }
}
