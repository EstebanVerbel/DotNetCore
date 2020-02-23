using StandardLibrary;
using System;

namespace DotNetCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageGen generator = new MessageGen();

            for (int i = 0; i < 10; i++)
            {
                generator.PrintMessage(i.ToString());
            }

        }
    }
}
