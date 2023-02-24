using System;
using TesteSolution02.Domain.Entities;
using TesteSolution02.Infra.Data.Repository;

namespace TesteSolution02.ConsoleApp
{
    class Program
    {
        public static Chamados chamados;
        public static Equipamento equipamento;

        const string sair = "S";

        static void Main(string[] args)
        {
             Console.WriteLine("Menu Principal");
            Console.WriteLine("1- Chamados\n2- Equipamentos\nS para Sair");
            string respo = "";
            respo = Console.ReadLine();

            while (respo.ToUpper() != sair)
            {
                if (respo == "1")
                {
                    MenuChamados();
                }

                if (respo == "2")
                {
                    MenuEquipamento();
                }


            }

        }
        public static void MenuChamados()
        {
            Console.WriteLine("Menu Chamado");
            Console.WriteLine("1 – Cadastrar\n2 – Editar\n3 – Consultar por Titulo\n4 – Consultar Todos\n5 – Excluir por Titulo\nDigite s para Voltar ");
            string respo = "";
            respo = Console.ReadLine();

            while (respo.ToUpper() != sair)
            {
                if (respo == "1")

                {
                    chamados = new Chamados();
                    Console.WriteLine("Titulo:");
                    chamados.Titulo = Console.ReadLine();
                    Console.WriteLine("Descricao:");
                    chamados.Descricao = Console.ReadLine();
                    Console.WriteLine("Data de Abertura:");
                    chamados.Data_Abertura = Convert.ToDateTime(Console.ReadLine());
                    ChamadosRepository.Inserir(chamados);

                }

                if (respo == "2")
                {
                    var busca = "";
                    Console.WriteLine("Titulo do Chamado que deseja Editar:");
                    busca = Console.ReadLine();

                    if (busca == chamados.Titulo)
                    {
                        Console.WriteLine("Titulo:");
                        chamados.Titulo = Console.ReadLine();
                        Console.WriteLine("Descricao:");
                        chamados.Descricao = Console.ReadLine();
                        Console.WriteLine("Data de Abertura:");
                        chamados.Data_Abertura = Convert.ToDateTime(Console.ReadLine());
                        ChamadosRepository.Editar(chamados);

                    }
                }

                if (respo == "3")
                {
                    var busca = "";
                    Console.WriteLine("Titulo do Chamado que deseja Consultar:");
                    busca = Console.ReadLine();

                    if (busca == chamados.Titulo)
                    {
                        ChamadosRepository.BuscarTodos(chamados);

                    }
                }
                if (respo == "4")
                {
                    ChamadosRepository.BuscarTodos(chamados);

                }

                if (respo == "5")
                {
                    var busca = "";
                    Console.WriteLine("Titulo do Chamado que deseja Excluir:");
                    busca =Console.ReadLine();

                    if (busca == chamados.Titulo)
                    {
                        ChamadosRepository.Excluir(chamados);
                    }


                }


            }


        }

        public static void MenuEquipamento()
        {

            Console.WriteLine("Menu Equipamento");
            Console.WriteLine("1 – Cadastrar\n2 – Editar\n3 – Consultar por Nome\n4 – Consultar Todos\n5 – Excluir por Nome\nDigite s para Voltar");
            string respo = "";
            respo = Console.ReadLine();

            while (respo.ToUpper() != sair)
            {
                if (respo == "1")

                {
                    equipamento = new Equipamento();
                    Console.WriteLine("Nome:");
                    equipamento.Nome = Console.ReadLine();
                    Console.WriteLine("Preco:");
                    equipamento.Preco = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Numero de Serie:");
                    equipamento.Numero_de_Serie = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Data de Fabricação:");
                    equipamento.Data_Fabricacao = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Fabricante:");
                    equipamento.Fabricante = Console.ReadLine();
                    EquipamentoRepository.Inserir(equipamento);

                }

                if (respo == "2")
                {
                    var busca = "";
                    Console.WriteLine("Nome do Equipamento que deseja Editar:");
                    busca = Console.ReadLine();

                    if (busca == equipamento.Nome)
                    {
                        equipamento = new Equipamento();
                        Console.WriteLine("Nome:");
                        equipamento.Nome = Console.ReadLine();
                        Console.WriteLine("Preco:");
                        equipamento.Preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Numero de Serie:");
                        equipamento.Numero_de_Serie = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Data de Fabricação:");
                        equipamento.Data_Fabricacao = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Fabricante:");
                        equipamento.Fabricante = Console.ReadLine();
                        EquipamentoRepository.Editar(equipamento);

                    }
                }

                if (respo == "3")
                {
                    var busca = "";
                    Console.WriteLine("Nome do Equipamento que deseja Consultar:");
                    busca = Console.ReadLine();

                    if (busca == equipamento.Nome)
                    {
                        EquipamentoRepository.BuscarTodos(equipamento);

                    }
                }
                if (respo == "4")
                {
                    EquipamentoRepository.BuscarTodos(equipamento);

                }

                if (respo == "5")
                {
                    var busca = "";
                    Console.WriteLine("Nome do Equipamento que deseja Excluir:");
                    busca = Console.ReadLine();

                    if (busca == equipamento.Nome)
                    {
                        EquipamentoRepository.Excluir(equipamento);
                    }


                }


            }
        }

    }
}
