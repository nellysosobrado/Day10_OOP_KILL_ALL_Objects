namespace Day10_OOP_KILL_ALL_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var building = new Building(); //Instance
            var goblin = new Goblin();
            var tresureChest = new TreasureChest();

            if(building is Building)
            {
                building.TakeDamage();
            }

            if(goblin is Goblin)
            {
                goblin.TakeDamage();
               
            } 
            if (tresureChest is TreasureChest)
            {
                tresureChest.TakeDamage();
            }
        }
    }
}
