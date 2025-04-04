namespace DesignPattern;

public class Build
{
    

    public class GameObject
    {
        public int x;
        public int y;
        public int z;

        public GameObject SetX(int x)
        {
            this.x = x;
            return this;
        }

        public GameObject SetY(int y)
        {
            this.y = y;
            return this;
        }

        public GameObject SetZ(int z)
        {
            this.z = z;
            return this;
        }
    } 
}