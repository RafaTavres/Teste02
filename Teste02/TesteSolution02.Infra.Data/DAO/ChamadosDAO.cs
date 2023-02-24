using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TesteSolution02.Domain.Entities;

namespace TesteSolution02.Infra.Data.DAO
{
   public class ChamadosDAO
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

        public static void Inserir(Chamados chamados)
        {
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand($"INSERT INTO TABELA_CHAMADOS VALUES(@Titulo,@Descricao,@Equipamento_Id,@Data_Abertura)",_conexao);      
            ConverterEntidadePAraMySqlCommand(comando,chamados);
            FecharConexao();
        }
        public static void BuscarTodos(Chamados chamados)
        {
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand($"Select * From TABELA_CHAMADOS",_conexao);      
            var leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                ConverterSQLReaderParaEntidade(comando,leitor);
                Console.WriteLine($"Título:{chamados.Titulo} - Descrição: {chamados.Descricao} - Data de Abertura: {chamados.Data_Abertura}");
            }
            FecharConexao();
        }

        public static void Excluir (Chamados chamados)
        {
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand("DELETE FROM TABELA_CHAMADOS WHERE Titulo = @Titulo", _conexao);
            comando.Parameters.AddWithValue("@Titulo",chamados.Titulo);
            FecharConexao();
        }

        public static void Editar(Chamados chamados)
        {
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand("UPDATE TABELA_CHAMADOS set Titulo = @Titulo,  Descricao =  @Descricao, Equipamento_Id, = @Equipamento_Id, Data_Abertura = @Data_Abertura WHERE Titulo = @Titulo", _conexao);
            ConverterEntidadePAraMySqlCommand(comando,chamados);
            FecharConexao();
        }

        private static Chamados ConverterSQLReaderParaEntidade(MySqlCommand comando, MySqlDataReader leitor)
        {
            var chamado = new Chamados();
            chamado.Titulo = "Titulo".ToString();
            chamado.Descricao = "Descricao".ToString();
            return chamado;
        }
        private static void ConverterEntidadePAraMySqlCommand(MySqlCommand comando,Chamados chamados)
        {
            comando.Parameters.AddWithValue("@Titulo",chamados.Titulo);
            comando.Parameters.AddWithValue("@Descricao",chamados.Descricao);
            comando.Parameters.AddWithValue("@Data_Abertura",chamados.Data_Abertura);

        }


    }
}