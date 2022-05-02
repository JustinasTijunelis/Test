using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        internal static Company SingleOrDefolt(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
        public Company(int id, string name, int countryId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
        }

        internal static Company SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
