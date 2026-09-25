using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    internal class Fort : Building, Attacker
    {
        private float attackDamage;
        public Fort(int id, string name, int x, int y, bool IsBuilt, float attackDamage) : base(id, name, x, y, IsBuilt)
        {
            this.attackDamage = attackDamage;
        }
        public void Attack(Unit unit)
        {
            if (IsBuilt())
            {
                unit.ReceiveDamage(attackDamage);
            }
        }
    }
}
