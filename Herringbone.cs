using System;

namespace Herringbone
{
    public class Herringbone
    {
        private char[,] _body;

        public Herringbone(char[,] body)
        {
            Initialize(body);
        }

        public void Show()
        {
            int width = _body.GetLength((int)Dimension.Width);
            int height = _body.GetLength((int)Dimension.Height);

            for (int i = (int)Number.Zero; i < height; i++)
            {
                for (int j = (int)Number.Zero; j < width; j++)
                    Console.Write($"{_body[i, j]}");

                Console.WriteLine();
            }
        }

        private void Initialize(char[,] body)
        {
            if (body == null)
                body = new char[(int)Number.Zero, (int)Number.Zero];

            _body = ArrayHelper.Parse(body);
        }
    }
}
