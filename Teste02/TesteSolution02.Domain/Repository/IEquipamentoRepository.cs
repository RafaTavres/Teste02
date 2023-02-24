using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSolution02.Domain.Entities;

namespace TesteSolution02.Domain.Repository
{
     public interface IEquipamentoRepository
    {
        void Inserir (Equipamento equipamento);
        void Editar(Equipamento equipamento);
        void Excluir(string Nome);
        void BuscarTodos(Equipamento equipamento);
    }
}