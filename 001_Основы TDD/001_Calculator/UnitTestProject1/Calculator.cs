﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    // Тестируемый класс.
    class Calculator
    {
        int x, y;

        public Calculator()
        {

        }

        public Calculator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y + 4;   // Логическая ошибка.
        }

        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
