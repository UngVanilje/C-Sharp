using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    internal class MyList
    {
        ArrayList list = new ArrayList();

        public MyList()
        {
        }

        public void Add(object number)
        {
            list.Add(number);
        }

        public void printNumbers()
        {
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
        public void addRandomNumbers()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(1, 100));
            }
        }
    }
        
    
}
