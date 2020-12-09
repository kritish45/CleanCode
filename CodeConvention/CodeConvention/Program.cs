using System;

namespace CodeConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TestClass
    {
        private string _myString;

        public TestClass(string myString)
        {
            this._myString = myString;
        }

        public string getString()
        {
            return _myString;
        }

        private void SetString(string myString)
        {
            this._myString = myString;
        }
    }
}
