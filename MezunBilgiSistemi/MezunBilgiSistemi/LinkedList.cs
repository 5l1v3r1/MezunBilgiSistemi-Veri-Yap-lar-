using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public class LinkedList:LinkedListADT
    {
        
        public override string GetElement(int position)
        {
            Node iter = Head;
            string temp = "";
            for (int i = 0; i < position; i++)
            {
                iter = iter.Next;
            }
            temp = Convert.ToString(iter.Data);
            return temp;
        }
        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += item.Data.Ad + Environment.NewLine +
                        item.Data.Adres + Environment.NewLine +
                        item.Data.OgrenciNumarasi + Environment.NewLine +
                        item.Data.DogumTarihi.ToShortDateString() + Environment.NewLine +
                        item.Data.Eposta + Environment.NewLine +
                        item.Data.Telefon.ToString() + Environment.NewLine +
                        item.Data.Uyruk + Environment.NewLine +
                        item.Data.YabanciDil + Environment.NewLine +
                        item.Data.İlgiAlani+Environment.NewLine+
                        item.Data.BasariBelgesi + Environment.NewLine+Environment.NewLine;


                      item = item.Next;
            }

            return temp;
        }
        public override void InsertFirst(Ogrenci_Bilgi o)
        {
            Node tempHead = new Node
            {
                Data = o
            };

            if (Head == null)
                Head = tempHead;
            else
            {
                tempHead.Next = Head;
                Head = tempHead;
            }
            Size++;
        }

        public override void InsertLast(Ogrenci_Bilgi o)
        {
            Node iter = Head;
            if (Head == null)
            {
                InsertFirst(o);
            }
            else
            {
                while (iter.Next != null)
                {
                    iter = iter.Next;
                }
                Node eklenecekNode = new Node { Data = o };
                eklenecekNode.Next = null;
                iter.Next = eklenecekNode;

            }
        }

        public override void DeletePos(int position)
        {
            Node iter = Head;
            for (int i = 1; i < position - 2; i++)
            {
                iter = iter.Next;
            }
            Node tempNode = new Node();
            tempNode = iter.Next.Next;
            iter.Next = tempNode;
            Size--;
        }
    }
}
