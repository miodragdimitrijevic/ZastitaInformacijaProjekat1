﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormClient
{
    class File
    {
        private string naziv;
        private byte[] nizbajtova;
        private string metoda;
        private string hashKod;

        public File(string naziv,string metoda,string hashKod)
        {
            this.naziv = naziv;
            this.metoda = metoda;
            this.hashKod = hashKod;
            nizbajtova = new byte[10000];
        }

        public string Naziv
        {
            get;
            set;
        }

        public string Metoda
        {
            get;
            set;
        }
        public byte[] Nizbajtova
        {
            get;
            set;

        }
        public string Hashkod
        {
            get;
            set;

        }


    }

  
}
