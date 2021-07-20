// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        // constructor
        public Archmage(string title) : base(title)
        {
            title = Title;
        }

        //method
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }

        public Storm CastLightningStorm()
        {
            return new Storm("lightning", true, Title);
        }
    }
}
