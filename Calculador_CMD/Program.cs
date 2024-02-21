using System.Reflection;

class Program{

    
        static int LeituraTeclado(){
            Console.WriteLine("Escolhe uma Opção Válida...");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }
        

     static void MenuPrincipal(){
            
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|        Bem Vindo a Calculadra      |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|1.  Adição                          |");
            Console.WriteLine("|2.  Subtracção                      |");
            Console.WriteLine("|3.  Multiplicação                   |");
            Console.WriteLine("|4.  Divisão                         |");
            Console.WriteLine("|5.  Diversos Calculos               |");
            Console.WriteLine("|------------------------------------|");
        }
        static int QuantosNumeros(){
            Console.WriteLine("Quantos Numéros Quer Adicionar?");
            int quantosNumeros = Convert.ToInt32(Console.ReadLine());
            return quantosNumeros;
        }
        //Metodo para Adição
        static void Adcionar(){
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|                Adição              |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("Quantos Numeros Deseja Adcionar");
            int qtdNumeros;
            double soma =0;

            while(!int.TryParse(Console.ReadLine(), out qtdNumeros) || qtdNumeros <= 0){
                Console.WriteLine("Numero Inválido, Insira um numero válido");
            }

            for(int i = 1; i<= qtdNumeros; i++){
                Console.WriteLine($"Adiciona o {i}º Numero ");
                //double numero = Convert.ToInt32(Console.ReadLine());

                while(true){
                    try{
                        double numero = Convert.ToDouble(Console.ReadLine());
                        soma += numero;
                        break;
                    } catch(FormatException){
                        Console.WriteLine("Insira um número válido.");
                    }
                }
            }
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|\tA soma dos numero é {soma}        |");
            Console.WriteLine("|------------------------------------|\n\n");

            Programa();
        }
        //Metódo para subtração
        static void Subtracao(){
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|              Subtração             |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("Quantos Numeros Deseja Adcionar");
            int qtdNumeros;
            double subtracao =0;

            while(!int.TryParse(Console.ReadLine(), out qtdNumeros) || qtdNumeros <= 0){
                Console.WriteLine("Numero Inválido, Insira um numero válido");
            }

            for(int i = 1; i<= qtdNumeros; i++){
                Console.WriteLine($"Escreva o {i}º Numero ");
                //double numero = Convert.ToInt32(Console.ReadLine());

                while(true){
                    try{
                        double numero = Convert.ToDouble(Console.ReadLine());
                        subtracao -= numero;
                        break;
                    } catch(FormatException){
                        Console.WriteLine("Insira um número válido.");
                    }
                }
            }
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|\tA soma dos numero é {subtracao}        |");
            Console.WriteLine("|------------------------------------|\n\n");

            Programa();
        }
        //Metódo para Multiplicação
        static void Multiplicacao(){
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|            Multiplicação           |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("Quantos Numeros Deseja Adcionar");
            int qtdNumeros;
            double multiplicacao =1;

            while(!int.TryParse(Console.ReadLine(), out qtdNumeros) || qtdNumeros <= 0){
                Console.WriteLine("Numero Inválido, Insira um numero válido");
            }

            for(int i = 1; i<= qtdNumeros; i++){
                Console.WriteLine($"Escreva o {i}º Numero ");
                //double numero = Convert.ToInt32(Console.ReadLine());

                while(true){
                    try{
                        double numero = Convert.ToDouble(Console.ReadLine());
                        multiplicacao = numero*numero;
                        break;
                    } catch(FormatException){
                        Console.WriteLine("Insira um número válido.");
                    }
                }
            }
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine($"|\tA Multiplicação dos numero é {multiplicacao}        |");
            Console.WriteLine("|----------------------------------------------|\n\n");

            Programa();
        }

        //Metodo para Divisão
        static void Divisao(){
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|               Divisão              |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("Quantos Numeros Deseja Adcionar");
            int qtdNumeros;
            double divisao =1;

            while(!int.TryParse(Console.ReadLine(), out qtdNumeros) || qtdNumeros <= 0){
                Console.WriteLine("Numero Inválido, Insira um numero válido");
            }

            for(int i = 1; i<= qtdNumeros; i++){
                Console.WriteLine($"Escreva o {i}º Numero ");
                //double numero = Convert.ToInt32(Console.ReadLine());

                while(true){
                    try{
                        double numero = Convert.ToDouble(Console.ReadLine());
                        divisao /= numero;
                        break;
                    } catch(FormatException){
                        Console.WriteLine("Insira um número válido.");
                    }
                }
            }
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine($"|\tA Multiplicação dos numero é {divisao}        |");
            Console.WriteLine("|--------------------------------------------------|\n\n");

            Programa();
        }

        static void Programa(){

            int opc=0;
            do{
                MenuPrincipal();
                opc = LeituraTeclado();
                
                switch(opc){
                    case (1):
                        Adcionar();
                       
                        break;
                    case (2):
                            Subtracao();

                        break;
                    case (3):
                            Multiplicacao();
                        break;
                    case (4):
                            Divisao();
                        break;
                    case (5):
                        break;
                    default:

                        break;
                }

                opc++;
            } while(opc < 0 || opc >5);    
        }

    
    static void Main(){
        Programa();        
    }
}