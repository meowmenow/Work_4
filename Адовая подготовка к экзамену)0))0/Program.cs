using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адовая_подготовка_к_экзамену_0__0
{
    class Program
    {

        //static double TriangleP(double a, double h)
        //{
        //    double b2, b;
        //    b2 = (a / 2) * 2 + h * 2;
        //    b = Math.Round(Math.Sqrt(b2), 2);
        //    return b;
        //}


        static void Main(string[] args)
        {
            ////Задание №1: 
            ////Ввести трёхзначное число. Определить - является ли оно перевёртышем.
            //int value;
            //Console.WriteLine("Введите трёхголовое число");
            //value = Convert.ToInt32(Console.ReadLine());
            //int x1 = value / 100;
            //int x2 = (value % 100) / 10;
            //int x3 = value % 10;
            //if (x1 == x3) Console.WriteLine("Перевёртыш");
            //else Console.WriteLine("Не перевёртыш");
            //Console.ReadKey();


            ////Задание №2: 
            ////Ввести три целых числа.
            ////Проверить истинность высказывания:"Хотя бы одно из чисел A, B, C положительное"
            //int x, y, z;
            //Console.WriteLine("Введите первую жертву");
            //x = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Введите вторую жертву");
            //y= Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Введите третью  жертву");
            //z = Convert.ToInt32(Console.ReadLine());
            //if (x > 0) Console.WriteLine("Тест положительный");
            //else Console.WriteLine("Тест отрицательный");
            //if (y > 0) Console.WriteLine("Тест положительный");
            //else Console.WriteLine("Тест отрицательный");
            //if (z > 0) Console.WriteLine("Тест положительный");
            //else Console.WriteLine("Тест отрицательный");
            //Console.ReadKey();

            ////Заданик №3:
            ////Описать функцию TriangleP(A, H), находящую периметр равнобедренного треугольника.
            ////По его основанию A и высоте H, проведённой к основаниб (A и H - вещественные).
            ////Для нахождения боковой стороны Y треугольника использовать теорему Пифагора:
            ////b2=(a/2)*2+h2
            ////Использовать функцию для решения задачи.            
            //double BEBR, CAPYBARA, b;
            //Console.WriteLine("Заложите фундамент, т.е. задайте основание");
            //BEBR = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Задайте высоту");
            //CAPYBARA = Convert.ToInt32(Console.ReadLine());
            //b = TriangleP(BEBR, CAPYBARA);
            //Console.WriteLine("Периметр " + b);
            //Console.ReadKey();

            //Задание №4:
            //Дан массив А размера N и целое число K (1<=K<=N). Вывести элементы массива с порядковыми номерами, кратными К.
            //int j, a, b;
            //Console.WriteLine("Задайте (домашку) размер массива");
            //j = Convert.ToInt32(Console.ReadLine());
            //int[] A = new int[j];
            //Random rnd = new Random();
            //for (b = 0; b < j; b++) A[b] = rnd.Next(200);
            //Console.WriteLine("Введите a");
            //a = Convert.ToInt32(Console.ReadLine());
            //for (b = 0; b < A.Length; b++) Console.Write(A[b] + " ");
            //Console.WriteLine(" ");
            //if (1 <= a && a <= j)
            //{
            //    for (b = 1; b < A.Length; b++)
            //    {
            //        if (A[b] % a == 0)
            //        {
            //            Console.WriteLine("Числа кратные a");
            //            Console.Write(A[b]);
            //        }
            //    }
            //}
            //else Console.WriteLine("Число a не подходит");
            //Console.ReadKey();


            //Задание №5:
            //Дана целочисленная матрица размера M x N. 
            //Найти номер первого из её столбцов, содержащих только нечётные числа.
            //Если таких столбцов нет, то выести 0
            //int B, i, r, d, h, u;
            //Random rnd = new Random();
            //Console.WriteLine("Задайте кол-во строк:");
            //B = Convert.ToInt32(Console.ReadLine());
            //u = B;
            //Console.WriteLine("Введите кол-во столбцов:");
            //i = Convert.ToInt32(Console.ReadLine());
            //int[,] matr = new int[B, i];
            //int[] mas = new int[i];
            //for (r = 0; r < B; r++)
            //    for (d = 0; d < i; d++)
            //        matr[r, d] = rnd.Next(10);
            //for (r = 0; r < B; r++)
            //{
            //    for (d = 0; d < i; d++)
            //    {
            //        Console.WriteLine(matr[r, d] + " ");
            //    }
            //    Console.WriteLine(" ");
            //}
            //for (d = 0; d < i; d++)
            //{
            //    h = 0;
            //    for (r = 0; r < B; r++)
            //    {
            //        if (matr[r, d] % 2 != 0)
            //        {
            //            h++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    if (h == u)
            //    {
            //        d = d + 1;
            //        Console.WriteLine($"{d}столбец");
            //        break;
            //    }
            //}
            //Console.ReadKey();
        }
    }
}

