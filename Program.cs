namespace Studying_Git_For_Visual_Studio
{
    internal class Program
    {

        static int pow(int c)
        {
            return c*c;
        }
        static int sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int g = pow(4);
            int h = pow(sum(g, g+1));
            Console.WriteLine("Hello, World!"+ g +"      dadada       " + h  );

        }
    }
}
