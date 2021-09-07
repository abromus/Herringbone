﻿namespace Herringbone
{
    public static class TestHerringbone
    {
        public static void Test1()
        {
            char[,] body = new char[,] { { '_', '*', '_', '_', '_', '_', '_', '_', '_' },
                                         { '*', '*', '_', '*', '_', '_', '_', '_', '_' },
                                         { '*', '_', '_', '_', '*', '_', '*', '_', '_' },
                                         { '*', '*', '*', '_', '_', '_', '_', '_', '_' },
                                         { '_', '_', '_', '_', '_', '*', '*', '*', '_' },
                                         { '*', '_', '*', '_', '*', '_', '_', '_', '_' },
                                         { '_', '*', '_', '_', '*', '*', '*', '_', '*' },
                                         { '*', '_', '*', '*', '*', '*', '*', '_', '*' },
                                         { '*', '*', '_', '*', '*', '*', '*', '_', '*' },
                                         { '*', '*', '*', '_', '_', '*', '*', '*', '*' },
                                         { '*', '*', '*', '*', '*', '*', '*', '_', '_' }};

            Herringbone herringbone = new Herringbone(body);
            herringbone.Show();
        }

        public static void Test2()
        {
            char[,] body = new char[,] { { '*', '_', '_', '_', '_', '_', '_', '_', '_' },
                                         { '_', '*', '_', '_', '_', '_', '_', '_', '_' },
                                         { '_', '_', '*', '_', '_', '_', '_', '_', '_' },
                                         { '_', '_', '_', '*', '_', '_', '_', '_', '_' },
                                         { '_', '_', '_', '_', '*', '_', '_', '_', '_' },
                                         { '_', '_', '_', '_', '_', '*', '_', '_', '_' },
                                         { '_', '_', '_', '_', '_', '_', '*', '_', '_' },
                                         { '_', '_', '_', '_', '_', '_', '_', '*', '_' },
                                         { '_', '_', '_', '_', '_', '_', '_', '_', '*' },
                                         { '*', '*', '*', '_', '_', '_', '_', '_', '_' },
                                         { '*', '*', '_', '*', '_', '_', '_', '_', '_' },
                                         { '*', '*', '_', '_', '*', '_', '_', '_', '_' },
                                         { '*', '*', '_', '_', '_', '*', '_', '_', '_' },
                                         { '*', '*', '_', '_', '_', '_', '*', '_', '_' },
                                         { '*', '*', '_', '_', '_', '_', '_', '*', '_' },
                                         { '*', '_', '*', '*', '_', '_', '_', '_', '_' },
                                         { '*', '_', '*', '_', '*', '_', '_', '_', '_' },
                                         { '*', '_', '*', '_', '_', '*', '_', '_', '_' },
                                         { '*', '_', '*', '_', '_', '_', '*', '_', '_' },
                                         { '*', '_', '*', '_', '_', '_', '_', '*', '_' },
                                         { '*', '_', '_', '*', '*', '_', '_', '_', '_' },
                                         { '*', '_', '_', '*', '_', '*', '_', '_', '_' },
                                         { '*', '_', '_', '*', '_', '_', '*', '_', '_' },
                                         { '*', '_', '_', '*', '_', '_', '_', '*', '_' },
                                         { '*', '_', '_', '*', '_', '_', '_', '_', '*' },
                                         { '*', '_', '_', '_', '*', '*', '_', '_', '_' },
                                         { '*', '_', '_', '_', '*', '_', '*', '_', '_' },
                                         { '*', '_', '_', '_', '*', '_', '_', '*', '_' },
                                         { '*', '_', '_', '_', '*', '_', '_', '_', '*' },
                                         { '*', '_', '_', '_', '_', '*', '*', '_', '_' },
                                         { '*', '_', '_', '_', '_', '*', '_', '*', '_' },
                                         { '*', '_', '_', '_', '_', '*', '_', '_', '*' },
                                         { '*', '_', '_', '_', '_', '_', '*', '*', '_' },
                                         { '*', '_', '_', '_', '_', '_', '*', '_', '*' },
                                         { '*', '_', '_', '_', '_', '_', '_', '*', '*' },
                                         { '_', '*', '*', '*', '_', '_', '_', '_', '_' },
                                         { '_', '*', '*', '_', '*', '_', '_', '_', '_' },
                                         { '_', '*', '*', '_', '_', '*', '_', '_', '_' },
                                         { '_', '*', '*', '_', '_', '_', '*', '_', '_' },
                                         { '_', '*', '*', '_', '_', '_', '_', '*', '_' },
                                         { '_', '*', '*', '_', '_', '_', '_', '_', '*' },
                                         { '_', '*', '_', '*', '*', '_', '_', '_', '_' },
                                         { '_', '*', '_', '*', '_', '*', '_', '_', '_' },
                                         { '_', '*', '_', '*', '_', '_', '*', '_', '_' },
                                         { '_', '*', '_', '*', '_', '_', '_', '*', '_' },
                                         { '_', '*', '_', '*', '_', '_', '_', '_', '*' },
                                         { '_', '*', '_', '_', '*', '*', '_', '_', '_' },
                                         { '_', '*', '_', '_', '*', '_', '*', '_', '_' },
                                         { '_', '*', '_', '_', '*', '_', '_', '*', '_' },
                                         { '_', '*', '_', '_', '*', '_', '_', '_', '*' },
                                         { '_', '*', '_', '_', '_', '*', '*', '_', '_' },
                                         { '_', '*', '_', '_', '_', '*', '_', '*', '_' },
                                         { '_', '*', '_', '_', '_', '*', '_', '_', '*' },
                                         { '_', '*', '_', '_', '_', '_', '*', '*', '_' },
                                         { '_', '*', '_', '_', '_', '_', '*', '_', '*' },
                                         { '_', '*', '_', '_', '_', '_', '_', '*', '*' },
                                         { '_', '_', '*', '*', '*', '_', '_', '_', '_' },
                                         { '_', '_', '*', '*', '_', '*', '_', '_', '_' },
                                         { '_', '_', '*', '*', '_', '_', '*', '_', '_' },
                                         { '_', '_', '*', '*', '_', '_', '_', '*', '_' },
                                         { '_', '_', '*', '*', '_', '_', '_', '_', '*' },
                                         { '_', '_', '*', '_', '*', '*', '_', '_', '_' },
                                         { '_', '_', '*', '_', '*', '_', '*', '_', '_' },
                                         { '_', '_', '*', '_', '*', '_', '_', '*', '_' },
                                         { '_', '_', '*', '_', '*', '_', '_', '_', '*' },
                                         { '_', '_', '*', '_', '_', '*', '*', '_', '_' },
                                         { '_', '_', '*', '_', '_', '*', '_', '*', '_' },
                                         { '_', '_', '*', '_', '_', '*', '_', '_', '*' },
                                         { '_', '_', '*', '_', '_', '_', '*', '*', '_' },
                                         { '_', '_', '*', '_', '_', '_', '*', '_', '*' },
                                         { '_', '_', '*', '_', '_', '_', '_', '*', '*' },
                                         { '_', '_', '_', '*', '*', '*', '_', '_', '_' },
                                         { '_', '_', '_', '*', '*', '_', '*', '_', '_' },
                                         { '_', '_', '_', '*', '*', '_', '_', '*', '_' },
                                         { '_', '_', '_', '*', '*', '_', '_', '_', '*' },
                                         { '_', '_', '_', '*', '_', '*', '*', '_', '_' },
                                         { '_', '_', '_', '*', '_', '*', '_', '*', '_' },
                                         { '_', '_', '_', '*', '_', '*', '_', '_', '*' },
                                         { '_', '_', '_', '*', '_', '_', '*', '*', '_' },
                                         { '_', '_', '_', '*', '_', '_', '*', '_', '*' },
                                         { '_', '_', '_', '*', '_', '_', '_', '*', '*' },
                                         { '_', '_', '_', '_', '*', '*', '*', '_', '_' },
                                         { '_', '_', '_', '_', '*', '*', '_', '*', '_' },
                                         { '_', '_', '_', '_', '*', '*', '_', '_', '*' },
                                         { '_', '_', '_', '_', '*', '_', '*', '*', '_' },
                                         { '_', '_', '_', '_', '*', '_', '*', '_', '*' },
                                         { '_', '_', '_', '_', '*', '_', '_', '*', '*' },
                                         { '_', '_', '_', '_', '_', '*', '*', '*', '_' },
                                         { '_', '_', '_', '_', '_', '*', '*', '_', '*' },
                                         { '_', '_', '_', '_', '_', '*', '_', '*', '*' },
                                         { '_', '_', '_', '_', '_', '_', '*', '*', '*' },
                                         { '*', '*', '*', '*', '*', '_', '_', '_', '_' },
                                         { '*', '*', '*', '*', '_', '*', '_', '_', '_' },
                                         { '*', '*', '*', '*', '_', '_', '*', '_', '_' },
                                         { '*', '*', '*', '*', '_', '_', '_', '*', '_' },
                                         { '*', '*', '*', '*', '_', '_', '_', '_', '*' },
                                         { '*', '*', '*', '_', '*', '*', '_', '_', '_' },
                                         { '*', '*', '*', '_', '*', '_', '*', '_', '_' },
                                         { '*', '*', '*', '_', '*', '_', '_', '*', '_' },
                                         { '*', '*', '*', '_', '*', '_', '_', '_', '*' }};

            Herringbone herringbone = new Herringbone(body);
            herringbone.Show();
        }
    }
}
