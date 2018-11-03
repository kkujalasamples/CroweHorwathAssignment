using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Repository
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message) => Console.WriteLine(message);
    }
}
