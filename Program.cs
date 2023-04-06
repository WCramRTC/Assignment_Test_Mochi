namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal()
            {
                Name = "Mochi",
                Breed = "Tux Cat",
                Legs = 4
            };
            Console.WriteLine($"{animal.Name} {animal.Breed} {animal.Legs}");
        }
    }
}