namespace Herringbone
{
    public static class ArrayHelper
    {
        public static char[,] Parse(char[,] array)
        {
            char[] tempArray1;
            char[] tempArray2;
            char fill = '*';
            int count1;
            int count2;
            int width = array.GetLength((int)Dimension.Width);
            int height = array.GetLength((int)Dimension.Height);

            for (int i = (int)Number.Zero; i < height; i++)
            {
                tempArray1 = BubbleSort(GetArray(array, i, (int)Number.Zero, width / (int)Number.Two + (int)Number.One), false);
                tempArray2 = BubbleSort(GetArray(array, i, width / (int)Number.Two + (int)Number.One, width / (int)Number.Two));
                count1 = CountFill(tempArray1, fill);
                count2 = CountFill(tempArray2, fill);

                SetArray(ref array, i, MakeArray(tempArray1, tempArray2));

                Align(ref array, i, count1, count2);
            }

            return array;
        }

        public static int CountFill(char[] array, char fill)
        {
            int count = (int)Number.Zero;

            foreach (var item in array)
                if (item == fill)
                    count++;

            return count;
        }

        public static void Align(ref char[,] body, int index, int count1, int count2)
        {
            int middleCount = (count1 + count2 + (int)Number.One) / (int)Number.Two;
            int middleIndex = body.GetLength((int)Dimension.Width) / (int)Number.Two;

            if (count1 == middleCount + (int)Number.One)
                Swap(ref body[index, middleIndex - middleCount], ref body[index, middleIndex + count2 + (int)Number.One]);
            else if (count1 > middleCount)
                for (int i = (int)Number.Zero; i < count1 - middleCount; i++)
                    Swap(ref body[index, count2 + i], ref body[index, middleIndex + i + (int)Number.One]);
            else if (count2 == middleCount)
                Swap(ref body[index, middleIndex - middleCount + (int)Number.One], ref body[index, middleIndex + count1 + (int)Number.One]);
            else if (count2 > middleCount)
                for (int i = (int)Number.Zero; i < middleIndex - middleCount; i++)
                    Swap(ref body[index, middleIndex + count2 - i], ref body[index, middleIndex - i]);
        }

        public static char[] BubbleSort(char[] array, bool isReverse = true)
        {
            int lenght = array.Length;

            for (int i = (int)Number.One; i < lenght; i++)
                for (int j = (int)Number.Zero; j < lenght - i; j++)
                    if (isReverse && array[j] > array[j + (int)Number.One] || isReverse == false && array[j] < array[j + (int)Number.One])
                        Swap(ref array[j], ref array[j + (int)Number.One]);

            return array;
        }

        public static char[] GetArray(char[,] array, int row, int column, int length)
        {
            char[] tempArray = new char[length];

            for (int i = (int)Number.Zero; i < length; i++)
                tempArray[i] = array[row, column + i];

            return tempArray;
        }

        public static void SetArray(ref char[,] array, int bodyIndex, char[] newArray)
        {
            int arraySize = newArray.GetLength((int)Dimension.Height);

            for (int i = (int)Number.Zero; i < arraySize; i++)
                array[bodyIndex, i] = newArray[i];
        }

        public static char[] MakeArray(char[] array1, char[] array2)
        {
            int array1Size = array1.GetLength((int)Dimension.Height);
            int array2Size = array2.GetLength((int)Dimension.Height);
            char[] tempArray = new char[array1.Length + array2.Length];

            for (int i = (int)Number.Zero; i < array1Size; i++)
                tempArray[i] = array1[i];

            for (int i = (int)Number.Zero; i < array2Size; i++)
                tempArray[array1Size + i] = array2[i];

            return tempArray;
        }

        private static void Swap(ref char first, ref char second)
        {
            char temp = first;
            first = second;
            second = temp;
        }
    }
}
