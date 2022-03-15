using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18.Model
{
    class Weapon
    {
        public int bulletCap;
        public int bulletCount;
        public double time;
        public bool auto = true;

        public Weapon(int bulletCap, int bulletCount, double time, bool auto)
        {
            this.bulletCap = bulletCap;
            this.bulletCount = bulletCount;
            this.time = time;
            this.auto = auto;
            if (bulletCount > bulletCap)
            {
                Console.WriteLine("Xeberdarliq:gulle sayi tutumdan cox ola bilmez");
            }
            
        }
        public void Shoot()
        {


            if (bulletCount <= 0)
            {
                Console.WriteLine("Gulle yoxdur");
            }
            else if (auto == true)
            {
                Console.WriteLine("azalir");
                bulletCount--;

                if (bulletCount > 0)
                {
                    bulletCount--;
                    
                }
                else
                {
                    Console.WriteLine("Gulle yoxdur");
                }

            }
            else
            {
                Console.WriteLine("azalir");
            }
        }
        
        public void Fire()
        {
            double shootbullets = 0;
            if (bulletCount == 0)
            {
                Console.WriteLine("gulle  yoxdur");
                return;
            }
            if (auto)
            {


                while (bulletCount > 0)
                {
                    bulletCount--;
                    shootbullets++;

                }
            }
            shootbullets *= (bulletCap / time);
            Console.WriteLine($"gulle bu qeder vaxta atildi:{shootbullets}");
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine(bulletCap-bulletCount);
        }
        public void Reload()
        {
            if (bulletCap - bulletCount == 0)
            {
                Console.WriteLine("doludur");
            }
            else
            {
                Console.WriteLine(bulletCap - bulletCount);
                bulletCount = bulletCap;


            }
        }
    }
}
    
