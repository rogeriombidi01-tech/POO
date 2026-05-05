namespace GestaoUniversitaria
{
    public abstract class Avaliacao : IAvaliavel
    {
        public float Peso { get; set; }
        public DateTime Data { get; set; }

        protected Avaliacao(float peso)
        {
            Peso = peso;
        }

        public abstract float CalcularNotaFinal();
    }


}


