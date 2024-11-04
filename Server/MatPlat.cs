using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class MatPlat : Machine, IGot
    {
        private string serianumber { get; set; }

        public string seriaNumber => serianumber;


        public MatPlat (string  Name, string SeriaNumber, int Price, int Cout)
        {
            Name = firmaName;
            SeriaNumber = seriaNumber;
            Price = price;
            Cout = cout;
        }

        public MatPlat() { }

        int IGot.MinVolume(int Volume)
        {
            cout -= Volume;
            return cout;
        }

        public string Stats
        {
            get
            {
                return $"Firma: {firmaName}, SeriaNumber: {seriaNumber}, Price: {price}, Cout: {cout}";
            }
        }
    }
}
