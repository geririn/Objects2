using System;

namespace Objects
{
    public class Dog : Animal, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Dog move");
        }
    }
}
