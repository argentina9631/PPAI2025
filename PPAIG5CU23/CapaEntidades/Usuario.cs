namespace CapaEntidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Usuario(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        // 21 : getNombre
        public string getNombre()
        {
            // Devuelve el nombre del usuario
            return Nombre;
        }
    }
}
