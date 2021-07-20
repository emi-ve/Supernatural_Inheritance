// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil
    {
        public string Title
        { get; private set; }

        // constructor

        public Pupil(string title)
        {
            Title = title;
        }

        // method

        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);

        }
    }
}
