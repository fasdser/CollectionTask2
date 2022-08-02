using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<string> list = new MyList<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");
            list.Add("g");
            list.Add("h");
            list.Add("i");
                
            foreach (var item in list)
                Console.WriteLine(item);

            Console.WriteLine(list.Count);
           
           
            Console.ReadLine();
        }
    }
}
