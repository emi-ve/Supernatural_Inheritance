// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        // constructor
        public Mage(string title) : base(title)
        {
            title = Title;
        }

        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);

        }
    }
}
