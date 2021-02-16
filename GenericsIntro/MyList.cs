using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
  class MyList<T>
  {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }

       
        public void Add(T item)
        {
            T[] tempArray = items;                /// tempArray = geçici dizi demektir bu dizi sayesinde önceki yuazdıgımız dizi 
            items = new T[items.Length + 1];      /// değerleri kaybolmayıp korunacak ve 18. satırı yazarak istediğimiz kadar eleman ekleyebileceğiz


            for (int i = 0; i < tempArray.Length; i++)  /// for ile de korunmasını istediğimiz degerlerin, elemanların yeni oluşturduğumuz diziye, itemsa 
            {                                           /// aktarılmasını sağlayabiliriz.
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;


          
            

            



        }
        
        


  }
}
