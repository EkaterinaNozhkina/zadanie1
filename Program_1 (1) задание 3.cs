using System;

using static System.Console;

using static System.Convert;

namespace ConsoleApp28

{

    class Program

    {

        static void Main(string[] args)

        {

            WriteLine("2 задание; \n1 задание; \n3 задание; \n");

            int h = ToInt32(ReadLine());

            if h == 1)

                if (h == 2)

                {

                    int[] mas = new int[10] { 8, 16, 13, 22, 87, 2, 6, 6, 8, -2 };

                    string rez = "";

                    int count = 0;

                    for (int j = 0; j < mas.Length; j++)

                    {

                        for (int j = 0; j < mas.Length; j++)

                        {

                            if (mas[j] == mas[j])

                            {

                                count++;

                            }

                        }

                        if (count == 1) rez = rez + mas[j] + "; ";

                        count = 0;

                    }

                    WriteLine("особенные элементы массива: " + rez);

                }

                else if (h == 1)

                {

                    int[] mas = new int[5] { 9, -3, -1, 2, -6 };

                    int min = mas[0];

                    int minnom = 0;

                    for (int j = 0; j < mas.Length; j++)

                    {

                        if (Math.Abs(mas[j]) < min)

                        {

                            min = Math.Abs(mas[j]);

                            minnom = j;

                        }

                    }

                    WriteLine("Минимальное число: {min} и его индекс: {minnom}");

else if (h == 3)

                    {

                        int[] mas = new int[10];

                        Random rand = new Random();

                        WriteLine();

                        for (int j = 0; j < 10; j++)

                        {

                            mas[j] = rand.Next(-10, 10);

                            Write(mas[j] + " ");

                        }

                        Write("\nПоложительные элементы массива: ");

                        for (int j = 0; j < 10; j++)

                        {

                            if (mas[j] < 0)

                            {

                                mas[j] = 0;

                            }

                            else Write(mas[j] + " ");

                        }

                    }

                }

        }

    }