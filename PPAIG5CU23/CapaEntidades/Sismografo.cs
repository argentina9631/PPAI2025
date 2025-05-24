namespace CapaEntidades
{
    public class Sismografo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // 45 : conocerSismografo
        public string getDescripcion()
        {
            return $"{Marca} {Modelo}";
        }
    }
}
