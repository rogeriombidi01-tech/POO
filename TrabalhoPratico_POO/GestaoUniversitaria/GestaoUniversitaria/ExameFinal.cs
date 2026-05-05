namespace GestaoUniversitaria
{
    public class ExameFinal : Avaliacao
    {
        public float NotaExame { get; set; }
        public ExameFinal(float peso, float nota) : base(peso) { NotaExame = nota; }

        public override float CalcularNotaFinal() => NotaExame * Peso;
    }

}


