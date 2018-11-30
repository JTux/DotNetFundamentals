using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Repository_Method_Refactored
{
    public class MockConsole : IConsole
    {
        public string OutPut { get; set; }

        public void Clear()
        {
            OutPut += "Cleared screen";
        }

        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            OutPut += "";
            return OutPut;
        }

        public void Write(string s)
        {
            OutPut += s;
        }

        public void WriteLine(string s)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(object o)
        {
            throw new NotImplementedException();
        }
    }
}
