namespace Models;

public class Professor(string nome, int idade, string disciplina, long matricula) {

    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
    public string Disciplina { get; set; } = disciplina;
    public long Matricula { get; set; } = matricula;

    public void ExibirInformacoes(){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}, Matricula: {Matricula}");
        Console.ResetColor();
    }
}