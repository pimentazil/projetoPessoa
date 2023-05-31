﻿using System;

namespace Pessoa
{
    internal class Program
    {
        // Método = Ação
        // String = texto
        // var - declaração de variaveis
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da pessoa");
            var nomePessoa = Console.ReadLine();
                        

            Console.WriteLine("Digite a data de nascimento da pessoa");
            var dataNascimentoPessoa = Console.ReadLine();
            var dataNascimento = Convert.ToDateTime(dataNascimentoPessoa);

            var anoAtual = DateTime.Now.Year;
            var idade = anoAtual - dataNascimento.Year;

            Console.WriteLine("Digite a altura");
            var altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o peso");
            var peso = Convert.ToDecimal(Console.ReadLine());

            var imc = Math.Round(peso / (altura * altura), 2);
            var classificacao = "";

            if (imc < (decimal)18.5)
            { 
                classificacao = "Abaixo do peso";
            }
            else if (imc >= (decimal)18.5 && imc <= (decimal)24.99)
            {
                classificacao = "Peso ideal";
            }
            else if (imc >= (decimal)25 && imc <= (decimal)29.99) 
            {
                classificacao = "Pré-Obesidade";
            }
            else if (imc >= (decimal)30 && imc <= (decimal)34.99)
            {
                classificacao = "Obesidade Grau I";
            }
            else if (imc >= (decimal)35 && imc <= (decimal)39.99)
            {
                classificacao = "Obesidade Grau II";
            }
            else 
            {
                classificacao = "Obesidade Grau III";
            }
          


            Console.WriteLine("Digite o salário bruto da pessoa");
            var salario = Convert.ToDouble (Console.ReadLine());

            var aliquota = 7.5;
            if (salario <= 1212)
            {
                aliquota = 7.5;
            }
            else if(salario >= 1212 && salario <= 2427.35)
            {
                aliquota = 9;
            }
            else if (salario >= 2427.36 && salario <= 3641.03)
            {
                aliquota = 12;
            }
            else
            {
                aliquota = 14;
            }

            var inss = (salario * aliquota) / 100;
            var salarioLiquido = salario - inss;

            Console.WriteLine("Digite o saldo da conta");
            var saldo = Convert.ToDecimal (Console.ReadLine());

            var dolar = (decimal)5.7;

            var saldoDolar = Math.Round(saldo / dolar, 2);

            Console.WriteLine("O nome da pessoa é: " + nomePessoa);
            Console.WriteLine("A idade da pessoa " + nomePessoa + " é " +  idade + " anos");
            Console.WriteLine("O IMC da pessoa é: " + imc + " Classificação: " + classificacao);
            Console.WriteLine("O desconto do INSS é: " + inss + " Aliquota: " + aliquota);
            Console.WriteLine("O Salário líquido é: " + salarioLiquido);
            Console.WriteLine("O saldo em dolar é: " + saldoDolar); 
        }

    }
}