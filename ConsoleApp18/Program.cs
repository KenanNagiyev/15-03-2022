using System;
using ConsoleApp18.Model;
namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Weapon w = new Weapon(30,15,5,"ikili");
           
            int choise = 0;
            while (choise!=4)
            {
                Console.WriteLine("choise");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 0:
                        {
                            w.Shoot();
                        }
                        break;
                    case 1:
                        {
                            w.Fire();
                        }
                        break;
                    case 2:
                        {
                            w.GetRemainBulletCount();
                        }
                        break;
                    case 3:
                        {
                            w.Reload();
                        }
                        break;
                    case 4:
                        {
                            w.GetInfo();
                        }
                        break;
                    default:
                        {

                        }
                        break;


                }
            }

        }

    }
}