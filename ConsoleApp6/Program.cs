using System;

namespace Data1
{
    class score
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 987; i++)
            {
                string Stri = i.ToString();
                if (Stri[0] != Stri[1] && Stri[1] != Stri[2] && Stri[0] != Stri[2])
                {
                    Console.Write("{0,4}", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку чтобы закрыть программу");
           
        }
    }

}