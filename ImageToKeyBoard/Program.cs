using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageToKeyBoard
{
    class Program
    {
        private static List<List<Color>> colorMap;
        private static Corale.Colore.Core.Color[][] colorMap2;
        static void Main(string[] args)
        {
            colorMap = new List<List<Color>>();
            ReadPixelColors();
            int colCount = 257;
            int rowCount = 0;
            foreach(List<Color> colorRow in colorMap)
            {
                colCount = PrintRow(colCount, colorRow);
                rowCount++;
                if (rowCount > 4)
                {
                    for(int i = 0; i < 3; i++)
                    {
                        PrintRow(GetColCount(i), colorMap[(rowCount+i)-4]);
                    }
                }
                colCount = GetColCount(rowCount);
            }

            Thread.Sleep(1000000);
        }

        private static int GetColCount(int rowCount)
        {
            switch (rowCount)
            {
                case 0:
                    return 257;
                case 1:
                    return 513;
                case 2:
                    return 769;
                default:
                    return 1025;
            }
        }

        private static int PrintRow(int colCount, List<Color> colorRow)
        {
            for (int i = 0; i < colorRow.Count; i++)
            {
                Color color = colorRow[i];
                try
                {
                    Corale.Colore.Core.Keyboard.Instance.Set((Corale.Colore.Razer.Keyboard.Key)colCount, new Corale.Colore.Core.Color(color.R, color.G, color.B));
                    colCount++;
                }
                catch (Exception)
                {
                    colCount++;
                    i--;
                }
                Console.WriteLine("Changing Color: " + color.ToString());
            }
            return colCount;
        }

        private static void ReadPixelColors()
        {
            Bitmap myBitmap = new Bitmap(@"C:\Users\Todd\Desktop\mario.png");
           // colorMap2 = new Corale.Colore.Core.Color[myBitmap.Height][];
            for (int y = 0; y < myBitmap.Height; y++)
            {
                //colorMap2[y] = new Corale.Colore.Core.Color[myBitmap.Width];
                colorMap.Add(new List<Color>());
                for (int x = 0; x < myBitmap.Width; x++)
                {
                    colorMap[y].Add(myBitmap.GetPixel(x, y));
                    Color color = myBitmap.GetPixel(x, y);
                    
                   // colorMap2[y][x] = new Corale.Colore.Core.Color(color.R, color.G, color.B);
                }
            }
            //Corale.Colore.Core.Keyboard.Instance.Set(colorMap2);
        }
    }
}
