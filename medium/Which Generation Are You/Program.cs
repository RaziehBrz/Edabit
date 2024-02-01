using System;
namespace Edabit
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        static string generation(int x, char y)
        {
            switch (x)
            {
                case -3:
                    return y == 'f' ? "great grandmother" : "great grandfather";
                case -2:
                    return y == 'f' ? "grandmother" : "grandfather";
                case -1:
                    return y == 'f' ? "mother" : "father";
                case 0:
                    return "me!";
                case 1:
                    return y == 'f' ? "daughter" : "son";
                case 2:
                    return y == 'f' ? "granddaughter" : "grandson";
                case 3:
                    return y == 'f' ? "great granddaughter" : "great grandson";
                default:
                    return "";
            }
        }
    }

}