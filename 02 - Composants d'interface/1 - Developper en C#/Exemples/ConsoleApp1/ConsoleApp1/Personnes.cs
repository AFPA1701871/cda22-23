using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Personnes
    {
        private int id;

        public Personnes(int id)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
    }
}
