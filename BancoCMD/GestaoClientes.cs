using System;
using System.Collections.Generic;
using System.Net.WebSockets;
class GestaoClientes{
        static List<string[]> clientes = new List<string[]>();

        static void MenuGestaoClientes(){       
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("|            Gestão de Clientes        |");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("|1.  Inserir Clientes                  |");
            Console.WriteLine("|2.  Alterar dados do Clientes         |");
            Console.WriteLine("|3.  Remover Clientes                  |");
            Console.WriteLine("|4.  Procurar Clientes pelo numero{bug}|");
            Console.WriteLine("|5.  Procurar Cliente pelo nome        |");
            Console.WriteLine("|6.  Listar Cliente                    |");
            Console.WriteLine("|7.  Listar Clientes Z-A)(disable)     |");
            Console.WriteLine("|8.  Sair                              |");
            Console.WriteLine("|--------------------------------------|");
        }
        public void InserirClientes(){
            Console.WriteLine("Quantos Clientes Deseja Adicionar");
            int qntCliente = Convert.ToInt32(Console.ReadLine());


            for (int i =1; i <= qntCliente; i++){
                Console.WriteLine("Nome do Cliente:");
                string nome = Console.ReadLine();

                Console.WriteLine("Idade do Cliente");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Morada do Cliente");
                string morada = Console.ReadLine();

                if(!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(Convert.ToString(idade)) && !string.IsNullOrEmpty(morada)){
                    string[] dadosClientes = {nome, Convert.ToString(idade), morada};
                    clientes.Add(dadosClientes);
                    Console.WriteLine($"Cliente {nome} Inserido \n");
                }   else{
                    Console.WriteLine("Falha, um dado nao fornecido");
                }
            }
            GestaoCliente();
        }

        public void AlterarDados(){
            Console.WriteLine("Lista de Clientes");
            ListarClientes();
            Console.WriteLine("Escoha o número do Clientes");
            int indice = LerIndiceCliente();

            if(indice >=0 && indice < clientes.Count){
                Console.WriteLine($"Cliente Actual: {clientes[indice]}");
                Console.WriteLine("Novo Nome do Cliente:");
                string novoNome = Console.ReadLine();

                Console.WriteLine("Nova Idade do Cliente");
                int novaIdade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nova Morada do Cliente");
                string novaMorada = Console.ReadLine();

                if(!string.IsNullOrEmpty(novoNome) && !string.IsNullOrEmpty(Convert.ToString(novaIdade)) && !string.IsNullOrEmpty(novaMorada)){
                    string[] novosDadosClientes = {novoNome, Convert.ToString(novaIdade), novaMorada};
                    clientes[indice] = novosDadosClientes;
                    Console.WriteLine("Dados Alterados com com sucesso");
                    Console.WriteLine($"Cliente {novoNome} Alterado \n");
                    GestaoCliente();
                }   else{
                    Console.WriteLine("Falha, um dado nao fornecido");
                }

            } else {
                Console.WriteLine("Indice inválido");
                GestaoCliente();
            }
        }
        public void RemoverClientes(){
            Console.WriteLine("Lista De Clientes");
            ListarClientes();

            Console.WriteLine("Escolha o número do cliente que deseja remover");
            int indice = LerIndiceCliente();

            //int indice = Convert.ToInt32(Console.ReadLine());
            if(indice >= 0 && indice < clientes.Count){
                string[] clienteRemovido = clientes[indice];
                clientes.RemoveAt(indice);
                Console.WriteLine($"Cliente {Convert.ToString(clienteRemovido)} removido com sucesso! \n");
            } else {
                Console.WriteLine("Índice inválido. Nenhum cliente removido.");
            }
            GestaoCliente();
        }

    public void ProcurarPeloNumero(){
        Console.WriteLine("Insira o número do cliente que deseja procurar:");
        int indice = LerIndiceCliente();

        if (indice >= 0 && indice < clientes.Count)
        {
            //string[] dadosCliente = clientes[indice];
            foreach(string[] dadosCLiente in clientes){
                Console.WriteLine($"Cliente encontrado: {dadosCLiente}");

            }
        }
        else
        {
            Console.WriteLine("Índice inválido. Nenhum cliente encontrado.");
        }

    }
   
    public void ProcurarClientesPeloNome()
    {
        Console.WriteLine("Insira o nome do cliente que deseja procurar:");
        string nome = Console.ReadLine();

        if (!string.IsNullOrEmpty(nome))
        {
            // Usar um loop para procurar o nome na lista de arrays de strings
            bool encontrado = false;
            foreach (string[] dadosCliente in clientes)
            {
                if (dadosCliente[0].Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Cliente encontrado: {string.Join(", ", dadosCliente)}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
    }


        public void ListarClientes(){
            for(int i = 0; i < clientes.Count; i++){
                string[] dadosCliente = clientes[i];
                Console.WriteLine($"{i + 1}. Cliente {dadosCliente[0]} - Idade: {dadosCliente[1]}, Morada: {dadosCliente[2]}");
            }
        }
        public void ListarClienteOrdemAZ(){
            clientes.Sort();
            ListarClientes();
        }
        /*static int LerIndiceClient(){
            Console.WriteLine("Insira o Indice Indice do Cliente");
            int indice = Convert.ToInt32(Console.ReadLine());
            return indice;
        }
        */
        static int LerIndiceCliente(){
            int indice;
            while (!int.TryParse(Console.ReadLine(), out indice) || indice < 1 || indice > clientes.Count)
            {
                Console.WriteLine("Índice inválido. Por favor, escolha um número de cliente válido.");
            }
            return indice - 1;
        }
        static int LeituraTeclado(){
            Console.WriteLine("Insira uma opção Válida");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }

    public void GestaoCliente(){
        int opc=0;
        do{
            MenuGestaoClientes();
            opc = LeituraTeclado();
            switch(opc){
                case (1):
                //MenuGestaoClientes(); 
                InserirClientes();     
                    break;
                case (2):
                    AlterarDados();
                    //AlterDadosClientes();
                    break;
                case (3):
                RemoverClientes();
                    break;
                case (4):
                ProcurarPeloNumero();
                    break;
                case (5):
                ProcurarClientesPeloNome();
                    break;
                case (6):
                ListarClientes();
                    break;
                case (7):
                ListarClienteOrdemAZ();
                    break;
                case 8:
                    //Console.WriteLine("Programa Encerrado");
                    break;
                default:
                    break;
            }
            opc++;
         } while(opc < 0 || opc >5);    
    } 
}