using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public class Samurai
    {
        private readonly IWeapon _weapon;
        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack(string enemy)
        {
            _weapon.Hit(enemy);
        }
    }
}
