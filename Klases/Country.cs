using Klases.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    public class Country
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public bool BelongsToEU { get; set; }

       public Country (int id, string code, string name, string continent, bool belongToEU)
        {
            Id = id;
            Code = code;
            Name = name;
            Continent = continent;
            BelongsToEU = belongToEU;
        }
    }
}
