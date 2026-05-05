
namespace GestaoUniversitaria
{
    public class Teste : Avaliacao
    {
        public float NotaTeorica { get; set; }
        public Teste(float peso, float nota) : base(peso) { NotaTeorica = nota; }

        public override float CalcularNotaFinal() => NotaTeorica * Peso;
    }

}


