using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Olimpiada<B,V,F>

        where B : Krepsinis
        where V : Futbolas
        where F : Badmentonas
    {
        private List<B> Krepsinis { get; set; }
        private List<V> Futbolas { get; set; }
        private List<F> Badmentonas { get; set; }

        public void Add(B team)
        {
            Krepsinis.Add(team);
        }

        public void Add(V team)
        {
            Futbolas.Add(team);
        }
        public void Add(F team)
        {
            Badmentonas.Add(team);
        }

    }

}
