using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSolution02.Domain.Entities;
using TesteSolution02.Domain.Repository;
using TesteSolution02.Infra.Data.DAO;

namespace TesteSolution02.Infra.Data.Repository
{
    public class ChamadosRepository
    {
        private ChamadosDAO chamadosDAO;

        public ChamadosRepository()
        {
            chamadosDAO = new ChamadosDAO();
        }
        public static void Inserir (Chamados chamados)
        {
            ChamadosDAO.Inserir(chamados);
        }
        public static  void  Editar(Chamados chamados)
        {
            ChamadosDAO.Editar(chamados);
        }
        public static void Excluir(Chamados chamados)
        {
            ChamadosDAO.Excluir(chamados);
        }
        public static void BuscarTodos(Chamados chamados)
        {
            ChamadosDAO.BuscarTodos(chamados);
        }

    }
}