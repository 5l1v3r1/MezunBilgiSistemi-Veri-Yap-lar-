using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public class LinkedListHashEnty
    {
        private int anahtar;

        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }

        private Heap hvalue;

        public Heap HValue
        {
            get { return hvalue; }
            set { hvalue = value; }
        }
        private Bolum_Bilgi bvalue;
        public Bolum_Bilgi BValue
        {
            get { return bvalue; }
            set { bvalue = value; }
        }

        private LinkedListHashEnty next;

        public LinkedListHashEnty Next
        {
            get { return next; }
            set { next = value; }
        }

        public LinkedListHashEnty(int anahtar, Heap hvalue, Bolum_Bilgi b)
        {
            this.anahtar = anahtar;
            this.hvalue = hvalue;
            this.bvalue = b;
            this.next = null;
        }
    
    }
}
