//Nivel 1: variaveis e operações Basicas
#region 1. calculadora de Media
using System.ComponentModel.Design;

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

int recipiente = A;
A = B;
B = recipiente;

Console.WriteLine("\nValores após a troca:");
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);

#endregion

//nivel 2:estruturas condicionais

#region 4. verificador de Mioridade
Console.Write("qual sua idade?");
int idade_verificador = int.Parse(Console.ReadLine());
Console.WriteLine(
     idade_verificador >= 18
     ? "voce é maior de idade"
    : "voce é menor de idade");
#endregion

#region 5. classificador de numero
Console.Write("digite um numero:");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0 && numero > 0)
{
    Console.WriteLine("o numero é par e positivo");
}
else if (numero % 2 != 0 && numero > 0)
{
    Console.WriteLine("o numero é impar e positivo");
}
else if (numero < 0)
{
    Console.WriteLine("o numero é negativo");
}
else
{
    Console.WriteLine("o numero é zero");
}



#endregion

#region 6. validação de login simples

int contador = 0;
string usuario_correto = "admin";
string senha_correta = "12345";

string usuario;
string senha_usuario;

do
{

    Console.Write("Digite o nome de usuário:");
    usuario = Console.ReadLine();
    Console.Write("Digite a senha:");
    senha_usuario = Console.ReadLine();

    if (usuario == usuario_correto && senha_usuario == senha_correta)
    {
        Console.WriteLine("Login bem-sucedido!");
        break;
    }
    else
    {
        Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
        contador++;
    }


} while (contador < 3);

#endregion

//nivel 3: estruturas de repetição

#region 7. contagem regressiva

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);

    if (i == 1)
        Console.Write("lançar!");
}



#endregion

#region 8. soma de impares

Console.Write("digite um numero inteiro positivo:");
int numero_impares = int.Parse(Console.ReadLine());

while ()


#endregion