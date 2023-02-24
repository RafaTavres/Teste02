using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TesteSolution02.Domain.Entities;

namespace TesteSolution02.Infra.Data.DAO
{
    public class EquipamentoDAO
    {
        public static MySqlConnection _conexao = new MySqlConnection();

        public static void AbrirConexao()
        {
            var server = @"server=.\datasource = localhost;username = root;password=mysql123!;database=ServisosDoJuniorDB security=true;";
            _conexao.ConnectionString = server;
            _conexao.Open();
        }
        public  static void FecharConexao()
        {
            _conexao.Close();
        }

        public static void Inserir(Equipamento equipamento)
        {
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand($"INSERT INTO TABELA_EQUIPAMENTOS VALUES(@Nome,@Preco,@Numero_de_Serie,@Data_Fabricacao,@Fabricante)",_conexao);      
            ConverterEntidadePAraMySqlCommand(comando,equipamento);
            FecharConexao();
        }
        public static void BuscarTodos(Equipamento equipamento)
        {
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand($"Select * From TABELA_EQUIPAMENTOS",_conexao);      
            var leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                ConverterSQLReaderParaEntidade(comando,leitor);
                Console.WriteLine($"Nome:{equipamento.Nome} - Preco: {equipamento.Preco} - Data de Fabricacao: {equipamento.Data_Fabricacao} - Fabricante {equipamento.Fabricante}");
            }
            FecharConexao();
        }

        public static void Excluir (Equipamento equipamento)
        {
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand("DELETE FROM TABELA_EQUIPAMENTOS WHERE Nome = @Nome", _conexao);
            comando.Parameters.AddWithValue("@Nome",equipamento.Nome);
            FecharConexao();
        }

        public static void Editar(Equipamento equipamento)
        {
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand("UPDATE TABELA_EQUIPAMENTOS set Nome = @Nome,  Preco = @Preco, Numero_de_Serie, = @Numero_de_serie, Data_Fabricacao = @Data_Fabricacao WHERE Nome = @Nome", _conexao);
            ConverterEntidadePAraMySqlCommand(comando,equipamento);
            FecharConexao();
        }

        private static Equipamento ConverterSQLReaderParaEntidade(MySqlCommand comando, MySqlDataReader leitor)
        {
            var equipamento = new Equipamento();
            var _preco = "Preco";
            var _numero_de_serie = "Numero_de_Serie";
            var _data_fabricacao = "Data_Fabricacao";
            equipamento.Nome = "Nome".ToString();
            equipamento.Preco = Convert.ToDouble(_preco);
            equipamento.Numero_de_Serie = Convert.ToInt32(_numero_de_serie);
            equipamento.Data_Fabricacao = Convert.ToDateTime(_data_fabricacao);
            equipamento.Fabricante = "Fabricante".ToString();
            return equipamento;
        }
        private static void ConverterEntidadePAraMySqlCommand(MySqlCommand comando,Equipamento equipamento)
        {
            comando.Parameters.AddWithValue("@Nome",equipamento.Nome);
            comando.Parameters.AddWithValue("@Preco",equipamento.Preco);
            comando.Parameters.AddWithValue("@Numero_de_Serie",equipamento.Numero_de_Serie);
            comando.Parameters.AddWithValue("@Data_Fabricacao",equipamento.Data_Fabricacao);
            comando.Parameters.AddWithValue("@Fabricante",equipamento.Fabricante);

        }
    }
}