namespace HelloWorld_UsingPOO
{
    class HelloWorld_UsingPOO
    {
        public void PrintHelloWorld()
        {
            Console.WriteLine("Hello, World");
        }

        static void Main (string[] args)
        {
            HelloWorld_UsingPOO m_helloworldpoo = new HelloWorld_UsingPOO();
            m_helloworldpoo.PrintHelloWorld();
        }
    }
}