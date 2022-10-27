/*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
mensagem explicativa, conforme exemplos. */

int a, b, soma;
Console.WriteLine("Informe o primeiro numero:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo numero:");
b = int.Parse(Console.ReadLine());
soma = a + b;
Console.WriteLine("Soma = " + soma);