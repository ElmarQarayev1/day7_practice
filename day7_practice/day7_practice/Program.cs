using System;

namespace day7_practice;

class Program
{
    static void Main(string[] args)
    {

        #region task1
        //Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
        Console.WriteLine("a ededini daxil edin");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b ededini daxil edin");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("c ededini daxil edin");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine($"{a} ededi en boyukdur");

        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine($"{b} ededi en boyukdur");

        }
        else
        {
            Console.WriteLine($"{c} ededi en boyukdur");
        }
        #endregion


        #region task2

        //Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
        Console.WriteLine("bir yazi daxil edin");
        string word = Console.ReadLine();
        bool check = false;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'A')
            {
                check = true;
                break;
            }

        }
        if (check)
        {
            Console.WriteLine("yazinin icinde A herfi var");
        }
        else
        {
            Console.WriteLine("yazinin icinde A herfi yoxdur");
            //}
            #endregion

            #region task3
            //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

            Console.WriteLine("bir yazi daxil edin");
            string word1 = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] == 'A')
                {
                    count++;

                }

            }
            Console.WriteLine($"yazinin icinde {count} A herfi var");
            #endregion

            #region task4

            // Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir
            Console.WriteLine("bir eded daxil edin: ");

            int eded;
            do
            {
                eded = Convert.ToInt32(Console.ReadLine());


            } while (eded <= 0 || eded % 2 != 0);
            int w = eded * eded;

            Console.WriteLine("ededin kvadrati: " + w);


            #endregion

            #region task5

            // Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arraydaki {i + 1} ci ededi daxil edin:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("arraydaki ededlerin cemi: " + sum);
            #endregion

            #region task6

            // Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.Əgər verilmiş dəyər "programming"dirsə console-da 400 saat,
            //"design"dırsa 250 saat, "system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.

            Console.WriteLine("tehsil novunu daxil edin: ");

            string tn = Console.ReadLine();

            switch (tn)
            {
                case "programming":
                    Console.WriteLine("400 saat");
                    break;
                case "design":
                    Console.WriteLine("250 saat");
                    break;
                case "system":
                    Console.WriteLine("200 saat");
                    break;
                default:
                    Console.WriteLine("tehsil novu yanlisdir");
                    break;
            }

            #endregion

            #region task5_different_way
            //task 5 elave formasi
            Console.WriteLine("arrayin uzunlugunu daxil edin : ");

            int q = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[q];
            string output = "";

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"{i + 1} ci ededi daxil edin: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());

                if (i != 0 && arr1[i] >= 0)
                    output += "+";
                output += arr1[i];


            }
            int summ = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                summ += arr1[i];

            }
            output += $"={summ}";
            Console.WriteLine(output);

            #endregion

            #region task6_different_way
            //task 6 elave
            bool yoxlama;
            do
            {

                Console.WriteLine("tehsil novunu daxil edin: ");

                string tnt = Console.ReadLine();

                yoxlama = true;


                switch (tnt)
                {
                    case "programming":
                        Console.WriteLine("400 saat");
                        break;
                    case "design":
                        Console.WriteLine("250 saat");
                        break;
                    case "system":
                        Console.WriteLine("200 saat");
                        break;
                    default:
                        yoxlama = false;
                        Console.WriteLine("tehsil novu yanlisdir");
                        break;
                }

            } while (!yoxlama);

            #endregion
            #region task1_elave
            Console.WriteLine("v ededini daxil edin");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x ededini daxil edin");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("z ededini daxil edin");
            int z = Convert.ToInt32(Console.ReadLine());


            int big;
            if (v > x)
            {
                if (v > z)
                    big = v;
                else
                    big = z;
            }
            else if (x > z)
                big = x;
            else big = z;

            Console.WriteLine($"En boyuk eded: {big}");

            #endregion



            Console.ReadLine();
        }
    }
}
