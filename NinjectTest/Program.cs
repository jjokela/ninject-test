using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IWeapon>().To<Sword>();

            var samurai = kernel.Get<Samurai>();
            samurai.Attack("molok");

            kernel.Rebind<IWeapon>().To<Shuriken>();
            samurai = kernel.Get<Samurai>();
    
            samurai.Attack("iso sääski");


            IWeapon sword = new Sword();
            IWeapon shuriken = new Shuriken();

            var warrior1 = new Samurai(sword);
            var warrior2 = new Samurai(shuriken);

            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");

            Console.ReadLine();
        }
    }
}
