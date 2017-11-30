using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi
{
    public class Heap
    {
        public HeapDugumu[] heapArray;
        private int maxSize;
        private int currentSize;
        Random rnd = new Random();
        Ogrenci_Bilgi o;
        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapDugumu[maxSize];
            o = new Ogrenci_Bilgi();
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
      

        public bool Insert(Ogrenci_Bilgi ogr)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(ogr);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && heapArray[parent].deger < bottom.deger)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMax() 
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public Ogrenci_Bilgi GetMax()
        {
            return heapArray[0].ogr;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
               
                if (rightChild < currentSize && heapArray[leftChild].deger < heapArray[rightChild].deger)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.deger >= heapArray[largerChild].deger)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public bool Ogrenci(string x)
        {

            for (int i = 0; i < currentSize; i++)
            {
                if (heapArray != null)
                {
                    if (x == heapArray[i].ogr.OgrenciNumarasi)
                        return true;
                }
            }
            return false;
        }
        
        public bool SistemdenSil(Ogrenci_Bilgi bilgi)
        {
            for (int i = 0; i < 100; i++)
            {
                
                if (heapArray[i].ogr.OgrenciNumarasi == bilgi.OgrenciNumarasi)
                {
                    heapArray[i].ogr = null;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }
        public bool KisiGuncelle(Ogrenci_Bilgi o)
        {
            for (int i = 0; i < currentSize; i++)
            {
                if (heapArray[i].ogr.OgrenciNumarasi == o.OgrenciNumarasi)
                {
                    heapArray[i].ogr = o;
                    return true;
                }
            }
            return false;
        }
        public string HeapGörüntüle()
        {
            string temp = "";
            for (int i = 0; i < currentSize; i++)
            {
                temp += "Adi : " + heapArray[i].ogr.Ad + Environment.NewLine +
                        "Adresi : " + heapArray[i].ogr.Adres + Environment.NewLine +
                        "Telefon No :" + heapArray[i].ogr.Telefon + Environment.NewLine +
                        "Mail Adresi : " + heapArray[i].ogr.Eposta + Environment.NewLine +
                        "Uyruğu : " + heapArray[i].ogr.Uyruk + Environment.NewLine;

            }
            return temp;
        }
        
       
    }
}
