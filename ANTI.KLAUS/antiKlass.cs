using System;

namespace ANTI.KLAUS
{
    public class Anti
    {
        public int hhp = 100;
        public void SetHp(int newhhp)
        {
            hhp = Math.Max(newhhp, 0);
        }

        public int GetHp()
        {
            return hhp;
        }
        public string name = "";

        public hoeWeapon weapon = new hoeWeapon();
        public bool isHoeAlive = true;
    }
    public class Klaus
    {
        public int hhp = 1500;
        public void SetHp(int newhhp)
        {
            hhp = Math.Max(newhhp, 0);
        }

        public int GetHp()
        {
            return hhp;
        }
        public string name = "";

        public hoeWeapon weapon = new hoeWeapon();
        public bool isHoeAlive = true;
    }

    public class hoeWeapon
    {
        public string weaponName = "";

        Random generator = new Random();
        // int r = generator.Next(2, 23);

        public int Damage()
        {
            return generator.Next(2, 23);
        }
    }
}