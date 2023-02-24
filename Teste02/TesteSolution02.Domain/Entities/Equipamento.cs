using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSolution02.Domain.Entities
{
    public class Equipamento
    {
        
        public string Nome {get;set;}
        public double Preco{get;set;}
        public int Numero_de_Serie{get;set;}
        public DateTime Data_Fabricacao{get;set;}
        public string Fabricante {get;set;}
    }
}