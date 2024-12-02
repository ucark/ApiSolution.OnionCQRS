using ApiSolution.Domain.Common;
using ApiSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSolution.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            
        }
        public Category(int parentid, string name, int priorty)
        {
            ParentId = parentid;
            Name = name;
            Priorty = priorty;
        }
        public required int ParentId { get; set; }
        public required string Name { get; set; }
        public required int Priorty { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
