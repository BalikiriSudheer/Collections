using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CollectionDemo
{
    internal class ListDemo
    {
        public void Lists()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
                 List<string> liststring = new List<string>();
            liststring.Add("sudheer");
           liststring.Add("kumar");
            liststring.Add("jayachandra");
            liststring.Add("somu");

            List<bool> listbool = new List<bool>();
            listbool.Add(true);
            listbool.Add(false);
            listbool.Add(true);

            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in liststring)
            {
                Console.WriteLine(item);
            }
            foreach(var item in listbool)
            {
                Console.WriteLine(item);
            }
            List<double> listdouble = new List<double>();
            listdouble.Add(10.5);
            listdouble.Add(10);
            listdouble.Add(9);
            for(int i = 0; i < listdouble.Count; i++) {
                Console.WriteLine(listdouble[i]);
            }
            Console.WriteLine("-------");

            //listdouble.Remove(10);
            
            ///listdouble.RemoveAt(0);
            

           /// listdouble.Reverse();
           /// listdouble.RemoveRange(1, 2);
           
            Console.WriteLine(listdouble.Count);
            

            foreach(var item in listdouble)
            {
                Console.WriteLine(item);
            }





        }
    }
}
