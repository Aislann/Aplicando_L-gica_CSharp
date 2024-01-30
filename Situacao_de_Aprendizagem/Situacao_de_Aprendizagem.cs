// Questão 1

//Console.WriteLine("Digite a base do terreno: ");
//double base_retangulo = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a altura do terreno:");
//double altura_retangulo = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("A área do terreno é: " + ((base_retangulo * altura_retangulo) / 2) + "m²");


//Questao 2
//Console.WriteLine("Digite a quantidade de cavalos em seu hara: ");
//int quantidade = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("A quantidade de ferraduras necessárias para equipar todos os cavalos são: " + quantidade * 4 + " haras");


//Questao 3
//Console.WriteLine("Digite o nome da pessoa: ");
//string nome = Convert.ToString(Console.ReadLine());

//Console.WriteLine("Digite a idade da pessoa: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"{nome} viveu aproximadamente: {idade * 365} dias");


//Questao 4
//double valor_litro = 5.58;

//Console.WriteLine("Digite o valor que irá colocar de gasolina: ");
//double valor_pagamento = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Foram colocados: {valor_pagamento / valor_litro} litros no tanque");


//Questao 5
//Console.WriteLine("Digite a quantidade de camisetas de tamanho P: ");
//int camisasP = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de camisetas de tamanho M: ");
//int camisasM = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de camisetas de tamanho G: ");
//int camisasG = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Valor das camisetas P: {camisasP * 10}\n" +
//    $"Valor das camisetas M: {camisasM *12}\n" +
//    $"Valor das camisetas G: {camisasG *15}\n" +
//    $"Valor total: R${(camisasP*10) + (camisasM*12) + (camisasG *15)},00");


//Questao 6
//Console.WriteLine("Digite o valor do salário: "); //Salario Original
//double salarioValor = Convert.ToDouble(Console.ReadLine());
//double salarioAumento = salarioValor + (0.15 * salarioValor); //Salario com aumento
//double salarioDesconto = 0.8 * salarioAumento; //Salario com imposto

//Console.WriteLine($"Salário inicial: {salarioValor}\n" +
//    $"Salário com aumento: {salarioAumento}\n" +
//    $"Salário final: {salarioDesconto}");


//Questao 7
//double π = 3.14;
//Console.WriteLine("Digite o valor do raio da caixa d´água: "); //Raio do cilindro
//double raio = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a altura da caixa d´água: "); //Altura do cilindro
//double altura = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("O volume de um cilindo é dado por: V= π r² h\n" +
//    $"Logo o volume será: {(π * Math.Pow(raio, 2) * altura):F2}");


//Questao 8
//Console.WriteLine("Digite o valor do produto: ");
//double precoNormal = Convert.ToDouble(Console.ReadLine());

//int i = 0;
//while(i < 1)
//{
//    Console.WriteLine("1- À vista em dinheiro ou cheque, recebe 10% de desconto\n" +
//    "2- À vista no cartão de crédito, recebe 15% de desconto\n" +
//    "3- Em duas vezes, preço normal de etiqueta sem juros\n" +
//    "4- Em duas vezes, preço normal de etiqueta mais juros de 10%\n" +
//    "0- Sair\n" +
//    "Escolha alguma opção: ");
//    int escolha = Convert.ToInt32(Console.ReadLine());

//    if (escolha == 0)
//    {
//        i++;
//        break;
//    }

//    double precoFinal = 0;

//    switch (escolha)
//    {
//        case 1:
//            // À vista em dinheiro ou cheque, recebe 10% de desconto
//            precoFinal = precoNormal * 0.9;
//            break;
//        case 2:
//            // À vista no cartão de crédito, recebe 15% de desconto
//            precoFinal = precoNormal * 0.85;
//            break;
//        case 3:
//            // Em duas vezes, preço normal de etiqueta sem juros
//            precoFinal = precoNormal;
//            break;
//        case 4:
//            // Em duas vezes, preço normal de etiqueta mais juros de 10%
//            precoFinal = precoNormal * 1.1;
//            break;
//        default:
//            Console.WriteLine("Opção inválida. Escolha uma condição de pagamento válida (1, 2, 3 ou 4).");
//            return;
//    }

//    Console.WriteLine($"O valor a ser pago é: R$ {precoFinal:F2}");
}



//Questao 9

//Console.WriteLine("Digite o valor em metros: ");
//double metros = Convert.ToDouble(Console.ReadLine());

//double centimetros = metros * 100;
//double milimetros = metros * 1000;
//double quilometros = metros / 1000;

//Console.WriteLine($"Valor em metros: {metros} m\n" +
//    $"Valor em centímetros: {centimetros} cm\n" +
//    $"Valor em milímetros: {milimetros} mm\n" +
//    $"Valor em quilômetros: {quilometros} km");


//Questao 10
//Console.WriteLine("Digite a quantidade de latas de 350 ml: ");//350ml
//int latas350ml = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de garrafas de 600 ml: ");//650ml
//int garrafas600ml = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de garrafas de 2 litros: ");//2L
//int garrafas2litros = Convert.ToInt32(Console.ReadLine());

//double totalLitros = (latas350ml * 0.35) + (garrafas600ml * 0.6) + (garrafas2litros * 2); //Convertendo em litros
//Console.WriteLine($"O comerciante comprou {totalLitros} litros de refrigerante.");
