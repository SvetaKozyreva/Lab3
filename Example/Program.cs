namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Example 1

            int j1;
            Console.WriteLine("Example1:\n\n Одновимірний масив iArray");
            int[] iArray = new int[10];

            for (j1 = 0; j1 < 10; j1++) iArray[j1] = j1 * j1;

            for (j1 = 0; j1 < 10; j1++)
            Console.WriteLine($"\n{j1} {iArray[j1]}");

            Console.WriteLine("\n Одновимірний масив chArray з ініціалізацією");
            char[] chArray = {'a','b','c','d'};
            j1 = -1;
            do
            {
                j1++;
                Console.WriteLine($"\n {j1} {chArray[j1]}");
            }
            while (chArray[j1] != 'd');

            Console.WriteLine();
            Console.Write("\n Значення присвоєно");
            Console.WriteLine("Не всі елементи масиву iiArray \n");

            int[] iiArray = new int[10];
            for (j1 = 0; j1 < 6; j1++)
            iiArray[j1] = j1 * j1;
            iiArray[9] = 81;

            foreach (int jj in iiArray)
            { Console.Write(" " +jj); }
            Console.WriteLine("\n\n");
            Console.Write(" ");

            //Example2
            Console.WriteLine("Example2:");

            int j2;
            string strValue;
            int[] iArray2 = new int[10];

            for (j2 = 0; j2 < 10; j2++)
{
                strValue = Console.ReadLine();
                iArray2[j2] = Convert.ToInt32(strValue);
            }

            for (j2 = 0; j2 < 10; j2++)
            Console.WriteLine($"\n {j2} {iArray2[j2]}");

            //Example 3
            Console.WriteLine("Example3:");

            int num1, num2;
            string str;
            double db1, db2;
            Random rnd = new Random();
            int[] iArray31 = new int[10];
            int[] iArray32 = new int[10];
            double[] dArray31 = new double[10];
            double[] dArray32 = new double[10];

            for (int j3 = 0; j3 < 10; j3++)
            {
                iArray31[j3] = rnd.Next(1, 101);
                iArray32[j3] = 50 - rnd.Next(1, 101);
            }

            for (int j3 = 0; j3 < 10; j3++)
            {
                num1 = rnd.Next(1, 101);
                db1 = Convert.ToDouble(num1);
                dArray31[j3] = db1 + Convert.ToDouble(rnd.Next(1, 101)) / 100;
                num2 = 50 - rnd.Next(1, 101);
                db2 = Convert.ToDouble(num2);

                dArray32[j3] = db2 - Convert.ToDouble(rnd.Next(1, 101)) / 100;
            }

            Console.WriteLine("\n----------------------------------------------- --");
            Console.WriteLine("\n Масиви типу int               Масиви типу double");
            Console.WriteLine("\n----------------------------------------------- --");
            for (int j3 = 0; j3 < 10; j3++)
            {
                str = string.Format("\n {0, 4:D} {1, 6:D} {2, 6:D} {3, 8:D} {4, 8:F2} {5, 8:F2}",
                                    j3, iArray31[j3], iArray32[j3], j3, dArray31[j3], dArray32[j3]);
                Console.WriteLine(str);
                Console.WriteLine("\n----------------------------------------------- ");
                Console.WriteLine();
            }

            //Example 4
            Console.WriteLine("Example4:");

            int j4;
            string strValue4;
            int[] iArray41 = new int[10];
            int[] iArray42 = new int[10];
            StreamReader sRead = new StreamReader("C:/Users/svtko/OneDrive/Робочий стіл/Лр3.txt");
            StreamWriter sWrite = new StreamWriter("C:/Users/svtko/OneDrive/Робочий стіл/Лр32.txt");

            for (j4 = 0; j4 < 10; j4++)
            {
                strValue4 = sRead.ReadLine();
                iArray41[j4] = Convert.ToInt32(strValue4);
                iArray42[j4] = 10 * iArray41[j4];
                strValue4 = string.Format("\n {0, 4:D} {1, 6:D} {2, 6:D}", j4, iArray41[j4], iArray42[j4]);
                Console.WriteLine(strValue4);
                Console.WriteLine();
                sWrite.WriteLine(iArray42[j4]);
            }

            sRead.Close();
            sWrite.Close();

            //Example 5
            Console.WriteLine("Example5:");

            int j5, num;
            string str5;
            string str51 = "Сума", str52 = "Сума";
            string str53 = "СрАрф", str54 = "СрАрф";
            double db51, db52;
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            Random rnd5 = new Random();
            int[] iArray51 = new int[15];
            int[] iArray52 = new int[15];
            double[] dArray51 = new double[15];
            double[] dArray52 = new double[15];

            for (j5 = 0; j5 < 15; j5++)
            {
                iArray51[j5] = rnd.Next(1, 101);
                iArray52[j5] = 50 - rnd.Next(1, 101);
                sum1 += iArray51[j5];
                sum2 += iArray52[j5];
            }

            for (j5 = 0; j5 < 15; j5++)
            {
                num = rnd.Next(1, 101);
                db51 = Convert.ToDouble(num);
                dArray51[j5] = db51 + Convert.ToDouble(rnd.Next(1, 101)) / 100;
                num = 50 - rnd.Next(1, 101);
                db52 = Convert.ToDouble(num);
                dArray52[j5] = db52 - Convert.ToDouble(rnd.Next(1, 101)) / 100;
                sum3 += dArray51[j5];
                sum4 += dArray52[j5];
            }

            Console.WriteLine("\n----------------------------------------------- -------------------");
            Console.WriteLine("\n Масиви типу int                                Масиви типу double ");
            Console.WriteLine("\n----------------------------------------------- -------------------");
            for (j5 = 0; j5 < 15; j5++)
            {
                str5 = string.Format("\n {0,10:D} {1,10:D} {2,10:D} {3,10:D} {4,10:F2} {5,10:F2}", j5,
                                    iArray51[j5], iArray52[j5], j5, dArray51[j5], dArray52[j5]);
                Console.WriteLine(str5);
            }
            Console.WriteLine("\n --------------------------------------------------- --------------");
            Console.WriteLine("\n {0} {2,10:F2} {3} {4,10:F2} {5,10:F2}", str51, sum1, sum2, str52,
                              sum3, sum4);
            Console.WriteLine("\n {0} {2,10:F2} {3} {4,10:F2} {5,10:F2}", str53, sum1 / 15, sum2 / 15,
                              str54, sum3 / 15, sum4 / 15);
            Console.WriteLine();

            //Example 6
            Console.WriteLine("Example6:");

            int j6, num6, sum6 = 0;
            Random rnd6 = new Random();
            int[] iArray6 = new int[10];

            for (j6 = 0; j6 < 10; j6++)
            {
                iArray6[j6] = rnd6.Next(1, 101);
            }

            for (j6 = 0; j6 < 10; j6++)
            {
                num6 = Convert.ToInt32(iArray6[j6] % 2);
                if (num6 == 0) sum6 += iArray6[j6];
            }

            foreach (int jj6 in iArray6)
            {
                Console.Write(" " + jj6);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("\n Сума парних елементів = " + sum6);
            Console.WriteLine();
            Console.Write(" ");

            //Example 7
            Console.WriteLine("Example7:");

            int j7, jnum7 = 0;
            Random rnd7= new Random();
            int[] iArray7 = new int[20];

            for (j7 = 0; j7 < 20; j7++)
            {
                iArray7[j7] = 50 - rnd7.Next(1, 101);
            }

            for (j7 = 0; j7 < 20; j7++)
            {
                if (iArray7[j7] > 0) jnum7 += 1;
                if (jnum7 == 2) break;
            }

            foreach (int jj in iArray7)
            {
                Console.Write(" " + jj);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("\n індекс другого позитивного елемента = " + j7);
            Console.WriteLine("\n iArray[" + j7 + "] = " + iArray7[j7]);

            jnum7 = 0;
            for (j7 = 0; j7 < 20; j7++)
            {
                if (iArray7[j7] < 0) jnum7 += 1;
                if (jnum7 == 3) break;
            }

            Console.WriteLine("\n індекс третього негативного елемента = " + j7);
            Console.WriteLine("\n iArray[" + j7 + "] = " + iArray7[j7]);
            Console.WriteLine();
            Console.Write(" ");

            //Example 8
            Console.WriteLine("Example8:");

            int jnum8 = 0, N = 20;
            int jAA = 0, jBB = 0;
            int j8, k8, temp8;
            Random rnd8 = new Random();
            int[] iArray8 = new int[N];
            int[] jA = new int[N];
            int[] jB = new int[N];

            for (j8 = 0; j8 < N; j8++)
            {
                iArray8[j8] = rnd8.Next(1, 101);
            }

            Console.WriteLine("\n вихідний масив \n\n");
            foreach (int jj in iArray8)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");

            for (j8 = 0; j8 < N; j8++)
            {
                jnum8 = iArray8[j8] / 2;
                iArray8[j8] = Convert.ToInt32(iArray8[j8]);
                if (iArray8[j8] == jnum8 * 2)
                {
                    jA[jAA] = iArray8[j8];
                    jAA += 1;
                }
                else
                {
                    jB[jBB] = iArray8[j8];
                    jBB += 1;
                }
            }

            Console.WriteLine("\n масив A[ ] \n\n");
            foreach (int jj in jA)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("\n масив B[ ] \n\n");
            foreach (int jj in jB)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");

            // Сортування масиву А
            jAA -= 1;
            for (k8 = 0; k8 < jAA; k8++)
            {
                for (j8 = 0; j8 < jAA; j8++)
                {
                    if (jA[j8 + 1] < jA[j8])
                    {
                        temp8 = jA[j8];
                        jA[j8] = jA[j8 + 1];
                        jA[j8 + 1] = temp8;
                    }
                }
            }

            // Сортування масиву B
            jBB -= 1;
            for (k8 = 0; k8 < jBB; k8++)
            {
                for (j8 = 0; j8 < jBB; j8++)
                {
                    if (jB[j8 + 1] < jB[j8])
                    {
                        temp8 = jB[j8];
                        jB[j8] = jB[j8 + 1];
                        jB[j8 + 1] = temp8;
                    }
                }
            }

            Console.WriteLine("\n відсортований масив A[ ] \n\n");
            foreach (int jj in jA)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("\n відсортований масив B[ ] \n\n");
            foreach (int jj in jB)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");

        }
    }
}
