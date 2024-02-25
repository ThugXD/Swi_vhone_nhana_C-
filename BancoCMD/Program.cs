using System.Reflection;
using System.Reflection.Emit;

class Program{


    static int LeituraTeclado(){
        Console.WriteLine("Insira uma opção Válida");
        int opc = Convert.ToInt32(Console.ReadLine());
        return opc;
    }
        
        //Area dos Menus
   
    static void MenuPrincipal(){       
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|            Menu Principal          |");
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|1.  Gestão de Clientes              |");
        Console.WriteLine("|2.  Gestão de Vendas                |");
        Console.WriteLine("|3.  gestão de Veículos              |");
        Console.WriteLine("|4.  Gestão de Utilizadores          |");
        Console.WriteLine("|5.  Sair                            |");
        Console.WriteLine("|------------------------------------|");
    }

    static void MenuGestaoVeiculosLoja(){       
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|    Gestão dos Veiculos da Loja     |");
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|1.  Inserir Veiculos                |");
        Console.WriteLine("|2.  Alterar dados veiculos          |");
        Console.WriteLine("|3.  Remover Veículos                |");
        Console.WriteLine("|4.  Listar de Veículos              |");
        Console.WriteLine("|5.  Procurar                        |");
        Console.WriteLine("|------------------------------------|");
    }
    static void MenuGestaoUtilizadoresFuncionario(){       
        Console.WriteLine("|-------------------------------------------|");
        Console.WriteLine("|       Gestão de Funcionários       |");
        Console.WriteLine("|--------------------------------------------|");
        Console.WriteLine("|--------------------------------------------|");
        Console.WriteLine("|1.  Inserir  Utilizador Funcionário         |");
        Console.WriteLine("|2.  Alterar dados do Utilizador Funcionário |");
        Console.WriteLine("|3.  Remover Utilizador Funcionário          |");
        Console.WriteLine("|4.  Listar Utilizador Funcionário           |");
        Console.WriteLine("|5.  Procurar Utilizador Funcionário         |");
        Console.WriteLine("|--------------------------------------------|");
    }
    static void MenuGestaoUtilizadoresGerentes(){       
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|      Gestão dos Gerentes Loja      |");
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|1.  Inserir de Gerente              |");
        Console.WriteLine("|2.  Alterar de Gerente              |");
        Console.WriteLine("|3.  Remover de Gerente              |");
        Console.WriteLine("|4.  Listar de Gerente               |");
        Console.WriteLine("|5.  Procurar Gerente                |");
        Console.WriteLine("|------------------------------------|");
        
    }

        
        static void Programa(){

            int opc=0;
            do{
                MenuPrincipal();
                opc = LeituraTeclado();
                switch(opc){
                    case (1):
                    //MenuGestaoClientes(); 
                        GestaoClientes clientes = new GestaoClientes();
                        clientes.GestaoCliente();
                        break;

                    case (2):
                        //GestaoVeiculosLoja gestaoVeiculos = new GestaoVeiculosLoja();
                        //gestaoVeiculos.MenuVeiculoLoja();
                        //MenuGestaoAluguerVeiculos();
                        break;
                    case (3):
                        MenuGestaoVeiculosLoja();
                        break;

                    case (4):
                        MenuGestaoUtilizadoresFuncionario();
                        break;

                    case (5):
                        MenuGestaoUtilizadoresGerentes();
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