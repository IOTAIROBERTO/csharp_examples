namespace Herencia01
{
    public class Animal
    {
        public void Greet()
        {
            Console.WriteLine("Hola, soy un tipo de animal.");
        }
    }

    public class Dog : Animal
    {
        public void Greet2()
        {
            Console.WriteLine("Hola, soy un perro.");
        }
    }

    public class CallAnimals
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Greet();
            dog.Greet2();
        }
    } 
}