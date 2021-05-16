using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementação do Algoritmo de Euclides");
            var numeros = new int[2];
            var completo = false;

            while (!completo) {
                if (numeros[0] == 0)
                {
                    var num = "";
                    try {
                        Console.WriteLine("Informe o primeiro numero maior que 0 e tecle ENTER: ");
                        num = Console.ReadLine();
                        var n = Convert.ToInt32(num);
                        numeros[0] = n;
                    }
                    catch {
                        Console.WriteLine("Número Inválido");
                        Console.WriteLine("Informe o primeiro número ou tecle ENTER para encerrar.");
                        num = Console.ReadLine();
                    }
                }
                if (numeros[1] == 0)
                {
                    var num = "";
                    try {
                        Console.WriteLine("Informe o segundo número maior que 0 e tecle ENTER: ");
                        num = Console.ReadLine();
                        var n = Convert.ToInt32(num);
                        numeros[1] = n;
                    }
                    catch {
                        Console.WriteLine("Número Inválido");
                        Console.WriteLine("Informe o segundo número ou tecle ENTER para encerrar.");
                        num = Console.ReadLine();
                    }
                }

                completo = numeros[0] > 0 && numeros[1] > 0;
            }

            var menor = numeros[0] > numeros[1] ? numeros[1] : numeros[0];
            var maior = numeros[0] > numeros[1] ? numeros[0] : numeros[1];

            var part_int = (int)(maior / menor);
            var diferenca = maior - (part_int * menor);
            var ultimo_numero = menor;
            Console.WriteLine($"{maior} / {menor} = {part_int}");
            Console.WriteLine($"Diferença de {diferenca}");
            while (diferenca > 0)
            {
                part_int = (int)(ultimo_numero / diferenca);
                var prox_numero = diferenca;
                diferenca = ultimo_numero - (part_int * diferenca);
                ultimo_numero = prox_numero;
            }

            Console.WriteLine($"O MDC de {maior} e {menor} é {ultimo_numero}");
        }
    }
}
