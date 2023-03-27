using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_9
{
    internal abstract class RPG
    {
        protected string name;
        public RPG(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public abstract int GetAttack();

        public abstract int GetSpeed();

        public abstract int GetHealth();

        public abstract int GetArmor();
    }

    internal class Human : RPG
    {
        public Human() : base("Human")
        {

        }
        public override int GetArmor()
        {
            return 0;
        }

        public override int GetAttack()
        {
            return 20;
        }

        public override int GetHealth()
        {
            return 150;
        }

        public override int GetSpeed()
        {
            return 20;
        }
    }

    internal class Elf : RPG
    {
        public Elf() : base("Elf")
        {

        }
        public override int GetArmor()
        {
            return 0;
        }

        public override int GetAttack()
        {
            return 15;
        }

        public override int GetHealth()
        {
            return 100;
        }

        public override int GetSpeed()
        {
            return 30;
        }
    }


    internal abstract class HumanProffesion : RPG
    {
        protected RPG obj;

        public HumanProffesion(string name,RPG obj) : base(name)
        {
            this.obj = obj;
        }
    }

    internal class HumanWarior : HumanProffesion
    {
        public HumanWarior(RPG obj2) : base("Human Warior",obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() + 20;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() + 20;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() + 50;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() + 10;
        }
    }


    internal class Swordsman : HumanProffesion
    {
        public Swordsman(RPG obj2) : base("Swordsman", obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() + 20;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() + 40;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() + 50;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() - 10;
        }
    }

    internal class Archer : HumanProffesion
    {
        public Archer(RPG obj2) : base("Archer", obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() + 10;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() + 20;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() + 50;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() + 20;
        }
    }


    internal class Rider : HumanProffesion
    {
        public Rider(RPG obj2) : base("Rider", obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() + 100;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() - 10;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() + 200;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() + 40;
        }
    }


    internal abstract class ElfProffesion : RPG
    {
        protected RPG obj;

        public ElfProffesion(string name, RPG obj) : base(name)
        {
            this.obj = obj;
        }
    }

    internal class ElfWarior : ElfProffesion
    {
        public ElfWarior(RPG obj2) : base("Elf Warior", obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() + 20;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() + 20;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() + 100;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() - 10;
        }
    }


    internal class ElfMagician : ElfProffesion
    {
        public ElfMagician(RPG obj2) : base("Elf Magician", obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() + 20;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() + 10;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() - 50;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() + 10;
        }
    }


    internal class Сrossbowman : ElfProffesion
    {
        public Сrossbowman(RPG obj2) : base("Сrossbowman", obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() - 10;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() + 20;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() + 50;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() + 10;
        }
    }



    internal class EvilMage : ElfProffesion
    {
        public EvilMage(RPG obj2) : base("Evil Mage", obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() + 0;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() + 70;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() + 0;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() + 20;
        }
    }


    internal class GoodMage : ElfProffesion
    {
        public GoodMage(RPG obj2) : base("Good Mage", obj2)
        {
        }

        public override int GetArmor()
        {
            return obj.GetArmor() + 30;
        }

        public override int GetAttack()
        {
            return obj.GetAttack() + 50;
        }

        public override int GetHealth()
        {
            return obj.GetHealth() + 100;
        }

        public override int GetSpeed()
        {
            return obj.GetSpeed() + 30;
        }
    }
}
