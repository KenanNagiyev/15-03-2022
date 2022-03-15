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
        public string auto ;

        public Weapon()
        {

        }
        public Weapon(int bulletCap, int bulletCount, double time, string auto)
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
        public void GetInfo()
        {
            Console.WriteLine($"gulle tutumu:{bulletCap}");
            Console.WriteLine($"gulle sayi:{bulletCount}");
            Console.WriteLine($"vaxti:{time}");
  

        }
        public void Shoot()
        {


            if (bulletCount <= 0)
            {
                Console.WriteLine("Gulle yoxdur");
            }
            else if (auto == "ikili")
            {
                
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
           
        }
        
        public void Fire()
        {
            double shootbullets = 0;
            if (bulletCount == 0)
            {
                Console.WriteLine("gulle  yoxdur");
                return;
            }
            if (auto == "ikili")
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
    
