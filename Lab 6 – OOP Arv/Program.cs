namespace Lab_6___OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish(true, default, "Male", 5, default, "Algae");
            fish.MakeSound();
        }
    }
}