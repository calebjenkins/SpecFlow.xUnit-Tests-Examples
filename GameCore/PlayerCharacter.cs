namespace GameCore
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
            Health = 100;
        }
        public void Hit(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                IsDead = true;
            }
        }
        public int Health { get; private set; } 
        public bool IsDead { get; set; }
    }
}
