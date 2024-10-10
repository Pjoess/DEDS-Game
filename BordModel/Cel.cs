using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordModel
{
    class Cel
    {
        public int RijNummer { get; set; }
        public int ColumnNummer { get; set; }
        public bool Bezet { get; set; }
        public string value{get;set;}

        public Cel(int x, int y)
        {
            RijNummer = x;
            ColumnNummer = y;
            value = "-";
        }
    }
}
