            int penutimoValor = 5;
            int ultimoValor = 6;
            int valorAtual = 8;
            int valorAtualAnterior;

            var n = 50;

            Console.WriteLine("1: " + penutimoValor);
            Console.WriteLine("2: " + ultimoValor);
            Console.WriteLine("3: " + valorAtual);

            for (int i = 4; i <= n; i++)
            {
                valorAtualAnterior = valorAtual;
                valorAtual = penutimoValor + ultimoValor;
                penutimoValor = ultimoValor;
                ultimoValor = valorAtualAnterior;

                Console.WriteLine(i + ": " + valorAtual);
            }

            Console.WriteLine("O quinquagésimo valor é " + valorAtual);