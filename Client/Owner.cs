﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Owner
    {
        private string name { get; set; }

        private string secondname { get; set; }

        private int balance { get; set; }

        private int coutofpurchizing { get; set; } = 0;

        public string Name => name;
        public string Secondname => secondname;
        public int Balance => balance;
        public int CoutOfPurchizing => coutofpurchizing;



        public Owner(string _name, string _secondname, int _balance, int _coutofpurchizing)
        {
            _name = Name;
            _secondname = Secondname;
            _balance = Balance;
            _coutofpurchizing = CoutOfPurchizing;
        }

        public Owner() { }



    }
}
