namespace HelloWorld_POO
{
    class HelloWorld_POO
    {
        public void PrintHelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        static void Main(string[] args)
        {
            HelloWorld_POO m_helloworldpoo = new HelloWorld_POO();
            m_helloworldpoo.PrintHelloWorld();
        }
    }
}