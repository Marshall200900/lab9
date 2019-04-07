using System;

namespace prog99
{
    class Program
    {

        public static double Input(string t)
        {
            bool ok = false;
            double a = 0;
            do
            {
                try
                {
                    Console.Write(t);
                    ok = true;
                    string s = Console.ReadLine();
                    a = double.Parse(s);
                }
                catch
                {
                    Console.WriteLine("Неверный формат");
                    ok = false;
                }
            } while (!ok);
            return a;
        }
        public static int InputInt(string t)
        {
            bool ok = false;
            int a = 0;
            do
            {
                try
                {
                    Console.Write(t);
                    ok = true;
                    string s = Console.ReadLine();
                    a = int.Parse(s);
                }
                catch
                {
                    Console.WriteLine("Неверный формат");
                    ok = false;
                }
            } while (!ok);
            return a;
        }
        static void Main(string[] args)
        {
            double x, y;
            Point p;


            //Нахождение расстояния от точки до начала координат
            Console.WriteLine("Вычисление расстояния от точки до начала координат");
            x = Input("Введите координату x: ");
            y = Input("Введите координату y: ");
            p = new Point(x, y);

            Console.WriteLine("Расстояние от точки до начала координат: " + 
                string.Format("{0:0.00}", Point.OriginDistance(p)));

            //Унарные операции
            Console.WriteLine("Работа с унарными операциями");
            x = Input("Введите координату x: ");
            y = Input("Введите координату y: ");
            p = new Point(x, y);

            Console.WriteLine("Уменьшение координаты x и y на 1: " + --p);
            Console.WriteLine("Смена значений x и y между собой: " + -p);

            //Приведение типов
            Console.WriteLine("Демонстрация работы приведения типа");
            x = Input("Введите координату x: ");
            y = Input("Введите координату y: ");
            p = new Point(x, y);
            int integer = p;
            Console.WriteLine("Неявное приведение к типу int, вывод целой части координаты x: " + integer);
            Console.WriteLine("Явное приведение к типу double, вывод координаты y: " + (double)p);

            //Бинарные операции
            Console.WriteLine("Демонстрация работы бинарных операций");
            x = Input("Введите координату x: ");
            y = Input("Введите координату y: ");
            p = new Point(x, y);

            double n = Input("Введите вычитаемое число: ");
            Console.WriteLine("Левосторонняя операция, уменьшение координаты x: " + (p - n));
            Console.WriteLine("Правосторонняя операция, уменьшение координаты y: " + (n - p));

            //Ввод второй точки для нахождения расстояния между ними
            Console.WriteLine("Введите координаты произвольной точки");
            double x1 = Input("Введите координату x: ");
            double y1 = Input("Введите координату y: ");
            Point p1 = new Point(x1, y1);

            Console.WriteLine($"Расстояние между точкой {p} и точкой {p1}: " + string.Format("{0:0.00}", (p - p1)));

            //Работа с массивом
            Console.WriteLine("Демонстрация работы массива точек");

            Console.WriteLine("Генерация массива со случайными значениями");
            int size = InputInt("Введите размер массива: ");
            PointArray arr1 = new PointArray(true, size);
            Console.WriteLine("Вывод массива со случайными числами: ");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Ручной ввод массива");
            size = InputInt("Введите размер массива: ");
            PointArray arr2 = new PointArray(false, size);
            Console.WriteLine("Массив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Наименьшее расстояние между точкой и началом координат в массиве - " + string.Format("{0:0.00}", arr2.FindShortestDistance()));
            Console.ReadKey();

        }
    }
}
