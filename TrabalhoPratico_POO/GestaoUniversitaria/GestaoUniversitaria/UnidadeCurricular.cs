namespace GestaoUniversitaria
{
    public class UnidadeCurricular
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        // Composição: As avaliações pertencem à UC
        private List<Avaliacao> _avaliacoes = new List<Avaliacao>();

        // Agregação: Estudantes existem independentemente
        private List<Estudante> _estudantes = new List<Estudante>();

        public void AdicionarAvaliacao(Avaliacao aval) => _avaliacoes.Add(aval);
        public void InscreverEstudante(Estudante est) => _estudantes.Add(est);

        public void EmitirPauta()
        {
            Console.WriteLine($"--- Pauta: {Nome} ({Codigo}) ---");

            // Simulação de atribuição de notas para demonstração
            var pauta = _estudantes.Select(est => new
            {
                Nome = est.Nome,
                NotaFinal = _avaliacoes.Sum(a => a.CalcularNotaFinal())
            })
            .OrderByDescending(x => x.NotaFinal);

            foreach (var item in pauta)
            {
                Console.WriteLine($"Estudante: {item.Nome} | Nota Final: {item.NotaFinal:F2}");
            }
        }
    }


}

