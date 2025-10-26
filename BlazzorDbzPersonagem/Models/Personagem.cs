using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazzorDbzPersonagem.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Planet { get; set; }
        public List<string> Transformations { get; set; }
    }
}