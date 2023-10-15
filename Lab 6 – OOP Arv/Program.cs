namespace Lab_6___OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish(true, "Male", 5, "Algae");
            fish.MakeSound();
            fish.SwimAround();

            Cat catOne = new Cat(true, "Female", 12, false);
            catOne.MakeSound();
            catOne.Hunting();

            Ape ape = new Ape(true, "Male", 17, 6);
            ape.MakeSound();
            ape.PeelBanana();

            Shark shark = new Shark(true, "Female", 20, 701.5);
            shark.MakeSound();
            shark.Attack();

            Squid squid = new Squid("Female", 3, "Carnivore", 2);
            squid.MakeSound();
            squid.InkDefense();

        }
    }
}