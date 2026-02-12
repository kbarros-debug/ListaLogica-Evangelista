//Nivel 1: variaveis e operações Basicas
#region 1. calculadora de Media
Console.Write("qual a primeira nota?");
double primeira_nota = double.Parse(Console.ReadLine());
Console.Write("qual a segunda nota?");
double segunda_nota = double.Parse(Console.ReadLine());
Console.Write("qual a terceira nota?");
double terceira_nota = double.Parse(Console.ReadLine());
double media = (primeira_nota + segunda_nota + terceira_nota) / 3;
Console.WriteLine($" A média do aluno é: {media}");

Console.Write(
    media >= 7
    ? ("parabens voce foi aprovado")
: media >= 5
    ? "voce esta de reccuperação"
    : "VOCE FOI REPROVADO");
#endregion

#region 2. conversor de idade

Console.Write("qual sua idade?");
int idade = int.Parse(Console.ReadLine());
int idade_em_dias = idade * 365;
Console.WriteLine($"sua idade em dias é:{idade_em_dias}");





#endregion

#region 3. troca de valores
int A = 10;
int B = 20;

Console.WriteLine("Valores originais:");
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);

// Troca dos valores
int temp = A;
A = B;
B = temp;

Console.WriteLine("\nValores após a troca:");
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);

#endregion

#region verificador de Mioridade




#endregion
