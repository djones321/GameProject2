﻿using System;

namespace GameProject2
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new LilDragon())
                game.Run();
        }
    }
}
