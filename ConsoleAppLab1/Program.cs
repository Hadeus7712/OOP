using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresLibrary;

namespace ConsoleAppLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double abscissaOfPoint;
            double ordinateOfPoint;
            string itemOfMenu;
            double x;
            double y;
            Point[] pnts = new Point[4];
            Rhombus theRhomb = new Rhombus();
            do
            {
                Console.WriteLine("Введите абсциссу первой точки ромба");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ордирату первой точки ромба");
                y = Convert.ToDouble(Console.ReadLine());
                pnts[0] = new Point(x, y);
                Console.WriteLine("Введите абсциссу второй точки ромба");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ордирату второй точки ромба");
                y = Convert.ToDouble(Console.ReadLine());
                pnts[1] = new Point(x, y);
                Console.WriteLine("Введите абсциссу третьей точки ромба");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ордирату третьей точки ромба");
                y = Convert.ToDouble(Console.ReadLine());
                pnts[2] = new Point(x, y);
                Console.WriteLine("Введите абсциссу четвёртой точки ромба");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ордирату четвёртой точки ромба");
                y = Convert.ToDouble(Console.ReadLine());
                pnts[3] = new Point(x, y);
                theRhomb = new Rhombus(pnts);
                Console.Clear();
                if (!theRhomb.IsExist())
                    Console.WriteLine("Ромб с заданными координатами не существует\n" + 
                        "Введите повторно координаты ромба");
            }
            while (!theRhomb.IsExist());
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1. Вычислить длины сторон ромба;");
                Console.WriteLine("2. Вычислить площадь ромба;");
                Console.WriteLine("3. Вычислить периметр ромба;");
                Console.WriteLine("4. Проверить принадлежность точки с заданными координатами фигуре или её границе;");
                Console.WriteLine("5. Задать новый ромб");
                Console.WriteLine("6. Выход.");
                itemOfMenu = Console.ReadLine();
                switch (itemOfMenu)
                {
                    case "1":
                        Console.WriteLine("Все стороны ромба равны и принимают значение: " + theRhomb.CalcSides());
                        break;
                    case "2":
                        Console.WriteLine("Площадь ромба:");
                        Console.WriteLine(theRhomb.Square());
                        break;
                    case "3":
                        Console.WriteLine("Периметр ромба:");
                        Console.WriteLine(theRhomb.Perimeter());
                        break;
                    case "4":
                        Console.WriteLine("Введите координату точки по оси Ох");
                        abscissaOfPoint = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату точки по оси Оy");
                        ordinateOfPoint = Convert.ToDouble(Console.ReadLine());
                        if (theRhomb.DoesBelongsToBorder(abscissaOfPoint, ordinateOfPoint))
                            Console.WriteLine("Точка с заданными координатами принадлежит границе фигуры");
                        else if (theRhomb.DoesBelongsToFigure(abscissaOfPoint, ordinateOfPoint))
                            Console.WriteLine("Точка с заданными координатами принадлежит фигуре, но не её границе");
                        else 
                            Console.WriteLine("Точка с заданными координатами не принадлежит фигуре");
                        break;
                    case "5":
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Введите абсциссу первой точки ромба");
                            pnts[0].x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите ордирату первой точки ромба");
                            pnts[0].y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите абсциссу второй точки ромба");
                            pnts[1].x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите ордирату второй точки ромба");
                            pnts[1].y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите абсциссу третьей точки ромба");
                            pnts[2].x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите ордирату третьей точки ромба");
                            pnts[2].y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите абсциссу четвёртой точки ромба");
                            pnts[3].x = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите ордирату четвёртой точки ромба");
                            pnts[3].y = Convert.ToDouble(Console.ReadLine());
                            theRhomb = new Rhombus(pnts);
                            Console.Clear();
                            if (!theRhomb.IsExist())
                                Console.WriteLine("Ромб с заданными координатами не существует\n" +
                                    "Введите повторно координаты ромба");
                        }
                        while (!theRhomb.IsExist());
                        break;
                    case "6":
                        Console.WriteLine("Выход из программы");
                        break;
                    default:
                        Console.WriteLine("Неправильно введён пункт меню");
                        break;
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
            while (itemOfMenu != "6");
        }
    }
}
