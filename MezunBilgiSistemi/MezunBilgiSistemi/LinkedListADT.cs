using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract string GetElement(int position);
        public abstract void InsertFirst(Ogrenci_Bilgi o);
        public abstract void InsertLast(Ogrenci_Bilgi o);
        public abstract void DeletePos(int position);
        public abstract string DisplayElements();
    }
}
