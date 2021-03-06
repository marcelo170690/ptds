﻿using System;

namespace softchape
{
    public class Singleton
    {
        private static Singleton instance = null;
        public int lvl { get; set; }

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
