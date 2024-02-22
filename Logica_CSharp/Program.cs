//Questao 1
//Console.WriteLine("Insira seu ano de nascimento: ");
//int ano = Convert.ToInt32(Console.ReadLine());

//int idade = 2024 - ano;

//if (ano < 1900)
//{
//    Console.WriteLine("Idade inválida");
//}
//else
//{
//    Console.WriteLine($"O usuário possui ou irá fazer: {idade} anos");
//}


//Questao 2
//Console.WriteLine("Digite o valor do raio da esfera: "); 
//double raio = Convert.ToDouble(Console.ReadLine());

//double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

//Console.WriteLine("O volume de uma esfera é dado por: V = 4/3πr³\n" +
//    $"O volume da esfera com raio {raio} é: {volume}");


//Questao 3
//int i = 0;

//while (i < 1)
//{
//    Console.WriteLine(
//        "1- Soma\n" +
//        "2- Subtração\n" +
//        "3- Multiplicação\n" +
//        "4- Divisão\n" +
//        "0- Parar\n" +
//        "Escolha uma opcao de 1 a 4: ");
//    int opcao = Convert.ToInt32(Console.ReadLine());
//    if (opcao == 0)
//    {
//        i++;
//        break;
//    }
//    Console.WriteLine("Digite um valor: ");
//    double num1 = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Digite o segundo valor:");
//    double num2 = Convert.ToDouble(Console.ReadLine());


//    switch (opcao)
//    {
//        case 1:
//            Console.WriteLine($"A soma dos números {num1} e {num2} é: " + $"{num1 + num2}\n");
//            break;
//        case 2:
//            Console.WriteLine($"A subtração dos números {num1} e {num2} é: " + $"{num1 - num2}\n");
//            break;
//        case 3:
//            Console.WriteLine($"A multiplicação dos números {num1} e {num2} é: " + $"{num1 * num2}\n");
//            break;
//        case 4:
//            Console.WriteLine($"A divisão dos números {num1} e {num2} é: " + $"{num1 / num2}\n");
//            break;
//    }

//}


//Questao 4
//Console.WriteLine("Informe o número para verificação: ");
//double num = Convert.ToDouble(Console.ReadLine());

//if(num >= 0)
//{
//    Console.WriteLine("O número é par!");
//}
//else
//{
//    Console.WriteLine("O número é impar!");
//}


//Questao 5
//Console.WriteLine("Informe o valor que possui em dolár: ");
//double dolar = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Informe o valor da cotação atual do dólar para real: ");
//double cotacao = Convert.ToDouble(Console.ReadLine());

//double valorReal = cotacao * dolar;
//Console.WriteLine($"O valor atual da cotação é: ${cotacao}, logo o valor em real será: R${(valorReal):F2}");



//Questao 6
Console.WriteLine("Informe a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
double media = (nota1 + nota2) / 2;
if (media >= 7)
{
    Console.WriteLine("O usuário está aprovado, recebe certificado");
}
else
{
    Console.WriteLine("O usuário não recebe certificado");
}
