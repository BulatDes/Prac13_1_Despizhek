using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Prac_13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);
            list.AddRange(new string[] { "Студент", "Петров" });
            foreach (object e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            list.Remove(0);
            list.Reverse();
            Console.WriteLine(list[1]);
                Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
                Console.WriteLine();

           
                ArrayList arlist = new ArrayList();
                Console.WriteLine("Введите размер новой коллекции");
                int count = int.Parse(Console.ReadLine());
                if (count < 0) throw new Exception("Error");
                Console.WriteLine("Заполните коллекцию любыми данными");
                for (int i = 0; i < count; i++)
                {
                    arlist.Add(Console.ReadLine());
                }
                Console.WriteLine("Введите индекс элемента колллекции c которого вы хотите добавить коллекцию");
                int ind = int.Parse(Console.ReadLine());
                if (ind < 0) throw new Exception("Error");
                list.InsertRange(ind,arlist);
                Console.WriteLine("Введите кол-во элементов которые хотите удалить из списка");
                int countrem = int.Parse(Console.ReadLine());
                int ind1 = ind / 2;
                if(countrem>list.Count-ind1+1)
                {
                    throw new Exception("Error");
                }
                list.RemoveRange(ind1,countrem);
                foreach(object u in list)
                {
                    Console.WriteLine(u);
                }
                /*for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }*/
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
        }
    }
}
