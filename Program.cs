int num1;
int num2;
int res;
string escolha;
string op;
Console.WriteLine("Calculadora desenvolvido por Lélo");
Console.WriteLine("====================================");
Console.WriteLine("[A] - Adição");
Console.WriteLine("[B] - Subtração");
Console.WriteLine("[C] - Multiplicação");
Console.WriteLine("[B] - Divisão");
Console.WriteLine("Digite uma opção: ");
escolha = Convert.ToString(Console.ReadLine());
Console.WriteLine("======================================");    

if (escolha == "A")
{ 
    Console.WriteLine("Voce escolheu adição!");
    Console.WriteLine("Digite o primeiro numero: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    res = num1 + num2;
    Console.WriteLine("A resposta do calculo eh: {0}", res);
}

else if (escolha == "B")
{
    Console.WriteLine("Voce escolheu subtração!");
    Console.WriteLine("Digite o primeiro numero: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    res = num1 - num2;
    Console.WriteLine("A resposta do calculo eh: {0}", res);
}

else if (escolha == "C")
{
    Console.WriteLine("Voce escolheu multiplicação!");
    Console.WriteLine("Digite o primeiro numero: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    res = num1 * num2;
    Console.WriteLine("A resposta do calculo eh: {0}", res);
}

else if (escolha == "D")
{
    Console.WriteLine("Voce escolheu Divisão!");
    Console.WriteLine("Digite o primeiro numero: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    res = num1 / num2;
    Console.WriteLine("A resposta do calculo eh: {0}", res);
}