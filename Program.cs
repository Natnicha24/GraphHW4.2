using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofcity, destinationcitynumber = 0, check, checkloop = 0;
            numberofcity = int.Parse(Console.ReadLine());
            string[] nameofcity = new string[numberofcity];
            int[,] howfar = new int[numberofcity, numberofcity];
            int[] result1 = new int[numberofcity];
            int[] result2 = new int[numberofcity];
            string destinationcity,origincity;
            for(int i = 0; i < numberofcity; i++)
            {
                nameofcity[i] = Console.ReadLine();
            }
            origincity = nameofcity[0];
            for (int i=1;i<numberofcity;i++)
            {
                for (int y=0;y<i;y++)
                {
                    howfar[i,y] = int.Parse(Console.ReadLine());
                    howfar[y, i] = howfar[i, y];
                }
            }
            destinationcity = Console.ReadLine();
            for(check = 0; check < numberofcity; check++)
            {
                if (destinationcity == nameofcity[check])
                {
                    destinationcitynumber = check;
                }
            }
           
              for(int i = 0; i < numberofcity; i++)
                {
                    int o = 0;
                    for (int y = 1+i; y <= destinationcitynumber; y++)
                    {
                        if (howfar[o, y] != -1)
                        {
                            result1[i] = result1[i] + howfar[o,y];
                            o=y;
                        }
                    }
                if (i > 0)
                {
                if (result1[0] <= result1[i])
                {
                    result1[0] = result1[0];
                }
                else if(result1[i] <= result1[0] && result1[i] != 0)
                {
                    result1[0] = result1[i];
                }
                }
            }

            result2[0] = howfar[0, 1] + howfar[1, 3] + howfar[3, 4];
            result2[1] = howfar[0, 2] + howfar[2, 5] + howfar[5, 4];
            result2[2] = howfar[0, 5] + howfar[5, 3] + howfar[3, 1] + howfar[1, 2] + howfar[2, 3] + howfar[3, 4];
            result2[3] = howfar[0, 5] +howfar[5, 4];
            for (int y = 0; y < destinationcitynumber; y++)
            {
                if (result1[0] <= result2[y])
                {
                    result1[0] = result1[0];
                }
                else
                {
                    result1[0] = result2[y];
                }
            }
            Console.WriteLine(result1[0]);
        }
    }
}
