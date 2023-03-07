//Распознавание точки
//Программа выполнена на языке C# с использованием библиотеки System.Drawing
//Выполнил: Пермяков И.C.
//Инструкция:
//В переменную partPath вставить путь до папки, в которой находятся .png файлы 


using System.Drawing;

public class TestPermyakov
{
    static void Main(string[] args)
    {
        bool dotFound = false;
        int maxX = -1000;
        int maxY = -1000;
        int minX = 100000;
        int minY = 100000;
        int X = 0;
        int Y = 0;
        string path = "";

        for (int k = 1; k < 9; k++)
        {
            dotFound = false;
            string partPath = "C:\\Users\\igorekmakarek\\Desktop\\TestRabota\\";
            path = partPath + k + ".png";

            Bitmap myBitmap = new Bitmap(path);
            Color defaultColor = myBitmap.GetPixel(0, 0);
            Color pixelColor = myBitmap.GetPixel(0, 0);

            for (int i = 0; i < myBitmap.Width; i++)
            {
                for (int j = 0; j < myBitmap.Height; j++)
                {
                    pixelColor = myBitmap.GetPixel(i, j);

                    if (pixelColor != defaultColor)
                    {
                        dotFound = true;

                        if (i > maxX)
                            maxX = i;
                        if (i < minX)
                            minX = i;
                        if (j > maxY)
                            maxY = j;
                        if (j < minY)
                            minY = j;
                    }
                }
            }
            X = (maxX - minX) / 2 + minX;
            Y = (maxY - minY) / 2 + minY;
            maxX = -1000;
            maxY = -1000;
            minY = 1000000;
            minX = 1000000;


            if (dotFound)
                Console.Write(k + "," + X + "," + Y + ";");

            
        }
    }
}
