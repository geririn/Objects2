using System;

namespace Objects
{
    public class Cat : Animal, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Cat move");
        }
    }
}
