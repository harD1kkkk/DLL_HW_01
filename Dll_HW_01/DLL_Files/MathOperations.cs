﻿using System;
namespace DLL_Files
{
    public static class MathOperations
    {
        public static int Max(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        public static int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
