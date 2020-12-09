using CodeConvention.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvention
{
    class TestClass : IMyInterface
    {
        private int _mynum1;
        private int _mynum2;
        public const int CONSTANT_NUMBER = 100;

        public TestClass(int mynum1, int mynum2)
        {
            this._mynum1 = mynum1;
            this._mynum2 = mynum2;
        }

        private int AddNumber (int myNum1, int myNum2)
        {
            return myNum1 + myNum2 + CONSTANT_NUMBER;
        }

        public int addNumberPublic (int myNum1, int myNum2)
        {
            return AddNumber(myNum1, myNum2);
        }
        
    }
}
