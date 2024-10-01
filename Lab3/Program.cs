using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    class El
    {
        public int B_num { get; set; }
        public int B_index { get; set; }
        public static El BiggerNum(int[] A, int N)
        {
            int B_Num = A[0];
            int B_Index = 0;

            for (int j = 1; j < N; j++)
            {
                if (A[j] > B_Num)
                {
                    B_Num = A[j];
                    B_Index = j;
                }
            }
            return new El { B_num = B_Num, B_index = B_Index };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int j;
            string strValue;
            int[] A = new int[15];

            while (true)
            {
                Console.WriteLine("Який спосіб заповнення масиву?:\n" +
                "1 - з клавіатури\n" +
                "2 - за допомогою генератора випадкових чисел\n" +
                "3- з файлу\n" +
                "0 - вихід");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0) { break; }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("З клавіатури:");
                        A = Clava(15);
                        break;
                    case 2:
                        Console.WriteLine("За допомогою генератора випадкових чисел:");
                        A = FRandom(15);
                        break;
                    case 3:
                        Console.WriteLine("З файлу:");
                        A = File(15);
                        break;

                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте знову.");
                        continue;
                }
                    
                for (j = 0; j < 15; j++)
                    Console.WriteLine($"\n{j + 1} {A[j]}");
                El result = El.BiggerNum(A, 15);
                    Console.WriteLine($"Найб. ел.:{result.B_num}; Його індекс: {result.B_index}");
            }

        }
        
        public static int[] Clava(int N)
        {
            int[] A = new int[N];
            for (int j = 0; j < N; j++)
            {
                string strValue = Console.ReadLine();
                A[j] = Convert.ToInt32(strValue);
            }
            return A;

        }
        public static int[] FRandom(int N)
        {
            Random rnd = new Random();
            int[] A = new int[N];
            for (int j = 0; j < N; j++)
            {
                A[j] = rnd.Next(1,16);
            }
            return A;
        }
        public static int[] File(int N)
        {
            StreamReader sRead = new StreamReader("C:\\Users\\svtko\\OneDrive\\Робочий стіл\\Лаби\\ООП2\\Lab3\\Lab3\\Лр3R14.txt");
            int[] A = new int[N];
            for (int j = 0; j < N; j++)
            {
                string strValue = sRead.ReadLine();
                A[j] = Convert.ToInt32(strValue);
            }
            sRead.Close();
            return A;
        }
        
    }
}
