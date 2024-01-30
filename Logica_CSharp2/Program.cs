//Questão 1

//int i = 10;
//int numTotal = 0;
//while(i > 0 && numTotal >=0)
//{
//    i--;
//    Console.WriteLine("Digite qualquer número inteiro: ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    numTotal += num;
//}
//Console.WriteLine($"A soma de todos os números é: {numTotal}");


//Questão 2
//Console.WriteLine("Digite o nome do aluno: ");
//string nome = Convert.ToString(Console.ReadLine());
//Console.WriteLine("Digite a primeira nota: ");
//double nota1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a segunda nota: ");
//double nota2 = Convert.ToDouble(Console.ReadLine());
//double media = (nota1 + nota2)/2;
//string situacao = "";
//if (media >= 6)
//{
//    situacao = "Aprovado";
//}
//else
//{
//    situacao = "Reprovado";
//}

//Console.WriteLine($"Aluno: {nome}\n" +
//    $"Média: {media}\n" +
//    $"Situação: {situacao}");


//Questão 3
//Console.WriteLine("Digite o valor do salário: ");
//double salario = Convert.ToDouble(Console.ReadLine());

//if (salario < 1500)
//{
//    Console.WriteLine($"O valor ajustado com a porcentagem é de: {(salario * 0.5) + salario}");
//}
//else if (salario >= 1500)
//{
//    Console.WriteLine($"O valor ajustado com a porcentagem é de: {(salario * 0.4) + salario}");
//}
//else if (salario > 4300)
//{
//    Console.WriteLine($"O valor ajustado com a porcentagem é de: {(salario * 0.3) + salario}");
//}

//Questão 4
//Console.WriteLine("Digite a idade do nadador: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 5 && idade <= 7)
//{
//    Console.WriteLine("Categoria: infantil A ");
//} else if (idade >= 8 && idade <= 10)
//{
//    Console.WriteLine("Categoria: infantil B ");
//} else if (idade >= 11 && idade <= 13)
//{
//    Console.WriteLine("Categoria: Juvenil A ");
//} else if (idade >= 14 && idade <= 17)
//{
//    Console.WriteLine("Categoria: Juvenil B ");
//} else if ( idade > 18)
//{
//    Console.WriteLine("Categoria: Adulto");
//}
//else
//{
//    Console.WriteLine("Categoria inexistente!");
//}


//Questão 5
//Console.WriteLine("Digite a quantidade de latas de 350 ml: ");//350ml
//int latas350ml = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de garrafas de 600 ml: ");//650ml
//int garrafas600ml = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite a quantidade de garrafas de 2 litros: ");//2L
//int garrafas2litros = Convert.ToInt32(Console.ReadLine());

//double totalLitros = (latas350ml * 0.35) + (garrafas600ml * 0.6) + (garrafas2litros * 2); //Convertendo em litros
//Console.WriteLine($"O comerciante comprou {totalLitros} litros de refrigerante.");


//Questão 6
//Console.WriteLine("Informe a primeira nota: ");
//double nota1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Informe a segunda nota: ");
//double nota2 = Convert.ToDouble(Console.ReadLine());
//double media = (nota1 + nota2) / 2;
//if (media >= 7)
//{
//    Console.WriteLine("O usuário está aprovado, recebe certificado");
//}
//else
//{
//    Console.WriteLine("O usuário não recebe certificado");
//}


//Questão 7
//Console.WriteLine("Digite os coeficientes a,b e c: ");

//Console.Write("Digite o valor de a: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite o valor de b: ");
//double b = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite o valor de c: ");
//double c = Convert.ToDouble(Console.ReadLine());

//double delta = b * b - 4 * a * c;

//if (delta < 0)
//{
//    Console.WriteLine("A equação não possui raízes reais.");
//}
//else if (delta == 0)
//{
//    double raiz = -b / (2 * a);
//    Console.WriteLine($"A equação possui uma raiz real: {raiz}");
//}
//else
//{
//    double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
//    double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
//    Console.WriteLine($"A equação possui duas raízes reais: {raiz1} e {raiz2}");
//}


//Questão 8
//Console.Write("Digite sua altura em metros: ");
//double altura = Convert.ToDouble(Console.ReadLine());
//Console.Write("Digite o peso em Kg: ");
//double quilos = Convert.ToDouble(Console.ReadLine());

//double imc = quilos / (altura * altura);
//if (imc < 18.5)
//{
//    Console.Write($"O IMC do individuo é: {imc}\n" +
//        $"Classificado como Magreza");
//} else if (imc >=18.5 && imc <= 24.9)
//{
//    Console.Write($"O IMC do individuo é: {imc}\n" +
//        $"Classificado como Normal");
//} else if(imc >= 25 && imc <= 29.9)
//{
//    Console.Write($"O IMC do individuo é: {imc}\n" +
//        $"Classificado como Sobrepeso");
//} else if(imc >= 30 && imc <= 39.9)
//{
//    Console.Write($"O IMC do individuo é: {imc}\n" +
//        $"Classificado como Obesidade");
//} else if (imc >= 40)
//{
//    Console.Write($"O IMC do individuo é: {imc}\n" +
//        $"Classificado como Obesidade Grave");
//} else
//{
//    Console.Write("Dados colocados incorretamente!");
//}
