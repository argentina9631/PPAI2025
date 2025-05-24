namespace CapaEntidades
{
    public class DetalleMuestraSismica
    {
        public TipoDeDato Tipo { get; set; }
        public double Valor { get; set; }

        // 41 : obtenerTipoDeDato
        public TipoDeDato obtenerTipoDeDato()
        {
            return Tipo;
        }
    }
}
