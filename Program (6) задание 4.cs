using System;

using static System.Convert;

using static System.Console;

using System.Collections;

namespace ConsoleApp29

{

    class Program

    {

        static void Main(string[] args)

        {

            ArrayList list = new ArrayList();

            list.Add('N');

            list.Add(-9);

            list.Add('M');

            list.Add(95);

            list.Add(-47);

            list.Add('P');

            list.Add(-1);

            list.Add(19);

            list.Add('e');

            list.Add(7);

            list.Add(-4);

            list.Add('O');

            list.Add(-13);

            list.Add('K');

            ArrayList list2 = new ArrayList();

            WriteLine("Числа: ");

            for (int j = 0; j < list.Count; j++)

            {

                int y = 0;

                string i = list[i] + "";

                bool rez = int.TryParse(i, out y); ;

                if (rez == false)

                {

                    if (i == i.ToUpper())

                    {

                        list2.Add(list[j]);

                        list.RemoveAt(j);

                    }

                    else list.RemoveAt(j);

                }

            }

            foreach (object o in list)

            {

                WriteLine(o);

            }

            WriteLine("Буквы заглавные: ");

            foreach (object o in list2)

            {

                WriteLine(o);

            }

            ReadLine();

        }

    }

}