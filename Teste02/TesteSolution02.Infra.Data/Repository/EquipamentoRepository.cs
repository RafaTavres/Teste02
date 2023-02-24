using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSolution02.Domain.Entities;
using TesteSolution02.Infra.Data.DAO;

namespace TesteSolution02.Infra.Data.Repository
{
    public class EquipamentoRepository
    {
         private EquipamentoDAO equipamentosDAO;

        public EquipamentoRepository()
        {
            equipamentosDAO = new EquipamentoDAO();
        }
        public static void Inserir (Equipamento equipamento)
        {
            EquipamentoDAO.Inserir(equipamento);
        }
        public static  void  Editar(Equipamento equipamento)
        {
            EquipamentoDAO.Editar(equipamento);
        }
        public static void Excluir(Equipamento equipamento)
        {
            EquipamentoDAO.Excluir(equipamento);
        }
        public static void BuscarTodos(Equipamento equipamento)
        {
            EquipamentoDAO.BuscarTodos(equipamento);
        }
    }
}