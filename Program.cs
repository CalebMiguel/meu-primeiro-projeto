string? entradaDoUsuário;
int primeiroNúmeroDoUsuário = 0;
int segundoNúmeroDoUsúario = 0;
string operador = " ";
float resultado = 0;
bool boolean1 = false;
bool boolean2 = false;

do
{
    Console.WriteLine("Por favor, insira um número inteiro ou insira 'Sair' para sair.");

    entradaDoUsuário = Console.ReadLine();

    if (boolean1 = int.TryParse(entradaDoUsuário, out primeiroNúmeroDoUsuário))
    {
        do
        {
            Console.WriteLine("\nEntre com um dos seguintes operadores ou insira 'Sair' para sair: +, -, *, /");

            entradaDoUsuário = Console.ReadLine();
            operador = entradaDoUsuário.Trim();

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                do
                {
                    Console.WriteLine("\nEntre com um segundo número ou insira 'Sair' para sair.");

                    entradaDoUsuário = Console.ReadLine();

                    if (boolean2 = int.TryParse(entradaDoUsuário, out segundoNúmeroDoUsúario))
                    {
                        switch (operador)
                        {
                            case "+":
                            resultado = primeiroNúmeroDoUsuário + segundoNúmeroDoUsúario;
                            break;

                            case "-":
                            resultado = primeiroNúmeroDoUsuário - segundoNúmeroDoUsúario;
                            break;

                            case "*":
                            resultado = primeiroNúmeroDoUsuário * segundoNúmeroDoUsúario;
                            break;

                            case "/":
                            resultado = primeiroNúmeroDoUsuário / segundoNúmeroDoUsúario;
                            break;

                        }
                        
                        Console.WriteLine($"\nO resultado da sua operação é: {resultado}\n");

                    }


                } while (resultado == 0 && entradaDoUsuário.ToLower() != "sair");
            }
        } while (operador != "+" && operador != "-" && operador != "*" && operador != "/" && entradaDoUsuário.ToLower() != "sair");
    }
    else
    {
        continue;
    }
} while (entradaDoUsuário.ToLower() != "sair");