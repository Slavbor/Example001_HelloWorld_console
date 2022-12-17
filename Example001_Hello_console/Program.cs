﻿using System;

public class MainClass
{
    public static void Main()
    {        
        Console.WriteLine("Введите значение радиуса круга");
        double r = Convert.ToDouble(Console.ReadLine()); // преобразуем введенную строку в число 
                                                         // и присваиваем его значение переменной

        double pi = Math.PI; //  число пи;

        //формулы для вычислений можно найти в интернете

        double perimeter = 2 * pi * r; //Запишите тут код для вычисления периметра круга
        double area = pi * Math.Pow(r, 2); //Запишите тут код для вычисления площади круга

        Console.WriteLine($"Периметр: {perimeter}, площадь: {area}"); 
    }
}