namespace Day250327_team_alone;

class Program
{
    public enum Parts {Head, Body, Arm, Leg, Hand, Foot, Size}; 
    
    class Player
    {
        private int hp = 10;
        private Armor armor;

        private event Action OnHit;
        
        public void Equip(Armor armor)
        {
            this.armor = armor;
            OnHit += armor.Hit;
        }

        public void Hit()
        {
            Console.WriteLine("플레이어가 공격 받았습니다.");
            hp -= 1;
            int totalHp = hp <= 0 ? 0 : hp;
            hp = totalHp;
            Console.WriteLine($"플레이어의 체력은{hp} 입니다.");
            OnHit?.Invoke();
        }

        public void Die()
        {
            Console.WriteLine("죽었습니다.");
        }
        
        public void UnEquip()
        {
            Console.WriteLine("갑옷이 없습니다.");
        }
    }

    class Armor
    {
        private int durability = 3;
        
        private Action OnHit;

        public void Brake()
        {
            Console.WriteLine("방어구가 깨졌습니다");
            OnHit?.Invoke();
        }

        public void Hit()
        {
            if (durability <= 0)
            {
                Brake();
            }
            else
            {
                Console.WriteLine($"내구성이 {durability}에서 {--durability} 으로 깍였습니다.");
            }
        }
    }
    
    static void Main(string[] args)
    {
        Player player = new Player();
        Armor armor = new Armor();
        
        player.Equip(armor);
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
        player.Hit();
    }
}