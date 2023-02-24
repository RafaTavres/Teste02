using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSolution02.Domain.Entities
{
    public class Chamados
    {
        
        public string Titulo {get;set;}
        public string Descricao{get;set;}
        public Equipamento equipamento{get;set;}
        public DateTime Data_Abertura{get;set;}
    }
}