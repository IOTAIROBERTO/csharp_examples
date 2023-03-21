namespace Herencia01
{
    public class Animal
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hola, soy algun tipo de animal.");
        } 
    }

    public class Dog : Animal
    {
        public override void Greet()
        {
            Console.WriteLine("Hola, soy un perro.");
        } 
    }

    public class CallAnimals
    { 
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Greet();
            Dog dog = new Dog();
            dog.Greet();
        }
    }
}