﻿namespace Studying_Git_For_Visual_Studio
{
    internal class Program
    {

        static int pow(int c)
        {
            return c*c;
        }
        static int mod(int a, int b)
        {
            return a % b;
        }
        static void decrease(ref int a, int decr)
        {
            a-=decr;
        }
        static int sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(mod(201, 10) + "       Adaaaaaaaada");
            int g = pow(4);
            int h = pow(sum(g, g+1));
            Console.WriteLine("Hello, World!"+ g +"      dadada       ");

            decrease(ref h, g);
            //jcndоставить оба варианта
            Console.WriteLine(h + "       Adaaaaaaaada" + g);
            Console.WriteLine("here mus be mod instead of all this trash!!!!");
            Console.WriteLine("its my first visual studio code starting");
        }

    }
}
