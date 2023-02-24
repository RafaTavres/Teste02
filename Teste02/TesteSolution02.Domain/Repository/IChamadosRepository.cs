using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSolution02.Domain.Entities;

namespace TesteSolution02.Domain.Repository
{
        public interface IChamadosRepository
    {
        void Inserir(Chamados chamados);
        void Editar(Chamados chamados);
        void Excluir(string Nome);
        void BuscarTodos(Chamados chamados);
    }
}