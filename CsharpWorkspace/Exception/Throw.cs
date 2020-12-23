using System;

namespace _12장_Throw_MainApp
{
    class MainApp
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine("arg : {0}", arg);
            }
            else
            {
                throw new Exception("arg가 10보다 큽니다.");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = i;


            try
            {
                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("{0}, {1}", e.Message, e.StackTrace);
                Console.ReadLine();
            }
            

        }
    }
}
