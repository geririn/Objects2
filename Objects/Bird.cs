using System;

namespace Objects
{
    public class Bird : Animal, IFlyeble
    {
        public void Fly()
        {
            Console.WriteLine("Bird fly");
        }
    }
}
