namespace BestGameEver
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HP_Potion potion = new HP_Potion(1, "Health Potion", 50, 1, 1);
            Weapon weapon1 = new Weapon(1, "Enormous Bazooka", "Bazooka", 50, 60, 100);
            Weapon weapon2 = new Weapon(2, "Small Shotgun", "Shotgun", 30, 50, 100);
            Weapon weapon3 = new Weapon(3, "Dretdretdret", "Sub-Machinegun", 30, 50, 100);
            Player playerOne = new Player(1, "Volodymyr Zelenskyj", 100, 0, weapon1, potion);
            Enemy enemy = new Enemy(1, "Vladimir Putin", 100, 1, weapon2, 10);


            Console.WriteLine("Welcome to TURAP!\nYou stand in front of...");
            Thread.Sleep(1000);
            Console.WriteLine(enemy.Name);
            Thread.Sleep(1000);

            bool gameOver = false;

            while (!gameOver)
            {
                Actions.Menu(playerOne, enemy);
                if (enemy.Health <= 0)
                {
                    gameOver = true;
                }
                if (enemy.Health > 0){
                    Actions.EnemyAttack(playerOne, enemy);
                    if (playerOne.Health <= 0)
                    {
                        gameOver = true;
                    }
                }
            }

            if (enemy.Health <= 0 && gameOver)
            {
                Console.WriteLine("YOU WIN!");
            }
            
            
            if (playerOne.Health <= 0 && gameOver)
            {
                Console.WriteLine("BUUUUH YOU LOSE");
            }

            //Combat


        }
    }
}
