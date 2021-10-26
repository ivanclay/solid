using System;

namespace SRP_Principle_Meets
{
    class RegisterLog : Ilogger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}
