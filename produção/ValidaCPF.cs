namespace Csharp
{
    class ValidaCPF
    {
        public static void MetodoCPFMain()
        {
            Console.Clear();
            
            Console.Write("Digite um CPF para ser validado: ");
            string valorDeEntrada = Console.ReadLine();

            string resultado = MetodoValidaCPF(valorDeEntrada);
            Console.Write($"O CPF validado é: {resultado}");
        }

        public static string MetodoValidaCPF(string CPF)
        {
            if(CPF.Length != 11 || CPF == "00000000000" || CPF == "11111111111" ||
                CPF == "22222222222" || CPF == "33333333333" || CPF == "44444444444" ||
                CPF == "55555555555" || CPF == "66666666666" || CPF == "77777777777" ||
                CPF == "88888888888" || CPF == "99999999999")
            {
                Console.WriteLine("CPF inválido. Tente novamente.");
                Console.ReadKey();
                MetodoCPFMain();
            }
            
            bool CPFValidado = true;

            // Cálculo do primeiro digito verificador.
            int soma = 0;
            int varAux = 0;
            int restoDivisao;
            char[] arrayNumerosCPF = CPF.ToCharArray();

            for(int cont = 0; cont <= 8; cont++)
            {
                soma += arrayNumerosCPF[cont] * (10 - varAux);
                varAux++;
            }

            restoDivisao = soma % 11;
            int primeiroDigitoVerificador;
            
            if(restoDivisao >= 2 || restoDivisao <=10)
            {
                primeiroDigitoVerificador = 11 - restoDivisao;

                // Realizando a validação
                if ( primeiroDigitoVerificador != arrayNumerosCPF[9])
                {
                    CPFValidado = false;
                }

            }
            else if(restoDivisao == 0 || restoDivisao == 1)
            {
                primeiroDigitoVerificador = 0;

                // Realizando a validação
                if ( primeiroDigitoVerificador != arrayNumerosCPF[9])
                {
                    CPFValidado = false;
                }

            }

            // Cálculo do segundo digito verificador.
            soma = 0;
            varAux = 0;

            for(int cont = 0; cont <=9; cont++)
            {   
                soma += arrayNumerosCPF[cont] * (11 - varAux);
                varAux++;
            }

            restoDivisao = soma % 11;
            int segundoDigitoVerificador;

            if(restoDivisao >= 2 || restoDivisao <=10)
            {
                segundoDigitoVerificador = 11 - restoDivisao;
            }
            else if(restoDivisao == 0 || restoDivisao == 1)
            {
                segundoDigitoVerificador = 0;
            }

            return Convert.ToString(CPFValidado);
        }
    }
}