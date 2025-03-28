namespace Day250327_team_alone;

class Program
{
    public enum Parts {Head, Body, Arm, Leg, Hand, Foot, Size}; 
    
    class Player
    {
        private int hp = 10;
        private Armor armor;
        private int defanse = 10;

        private event Action OnHit;
        
        public void Equip(Armor armor)
        {
            this.armor = armor;
            OnHit += armor.Hit;
        }

        public void Hit(int demage)
        {
            Console.WriteLine("플레이어가 공격 받았습니다.");
            hp -= demage;
            Console.WriteLine($"플레이어의 체력은{hp} 입니다.");
            
            if (armor.durability <= 0)
            {
                defanse = this.defanse + armor.defanse;
            }
            Console.WriteLine($"현재 방어력은 {defanse} 입니다.");
            if (hp <= 0) { Die(); }
            OnHit?.Invoke();
        }

        public void Die()
        {
            Console.WriteLine("죽었습니다.");
            Environment.Exit(0);
        }
        
        public void UnEquip()
        {
            Console.WriteLine("갑옷이 없습니다.");
        }
    }

    class Armor
    {
        public int durability { get; private set; } = 3;
        private Action OnBrake;
        public int defanse { get; private set; } = 10;
            
        public void Brake()
        {
            Console.WriteLine("방어구가 깨졌습니다");
            OnBrake?.Invoke();
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
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
        player.Hit(1);
    }
}