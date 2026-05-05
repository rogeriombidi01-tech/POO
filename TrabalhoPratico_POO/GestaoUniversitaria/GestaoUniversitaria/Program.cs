// 1. Criar a Unidade Curricular
using GestaoUniversitaria;

UnidadeCurricular uc = new UnidadeCurricular
{
    Nome = "Programação Orientada a Objetos",
    Codigo = "POO-2026"
};

// 2. Criar Docentes (Titular e Assistente)
Titular profTitular = new Titular
{
    Nome = "Pe.Nelson Malundu",
    Id = "002026",
    Especialidade = "Engenharia de Software",
    Departamento = "LICENCIATURA EM ENGENHARIA INFORMÁTICA"
};


Estudante est1 = new Estudante { Nome = "Rogério Mbidi", Id = "2022497", NumeroMatricula = 002202, Curso = "Informática" };
Estudante est2 = new Estudante { Nome = "Alipio Zambo", Id = "2021009", NumeroMatricula = 124, Curso = "Contabilidade" };


uc.InscreverEstudante(est1);
uc.InscreverEstudante(est2);


uc.AdicionarAvaliacao(new Teste(0.4f, 15.5f));      
uc.AdicionarAvaliacao(new Projecto(0.6f, 14.0f, 18.0f)); 


Console.WriteLine($"Docente Responsável: {profTitular.Nome} ({profTitular.Departamento})");
uc.EmitirPauta();

// Manter a consola aberta
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();