﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QA_Lab3_Nosov
{
    /// <summary>
    /// Вспомогательный класс Room содержит информацию о номере в отеле.
    /// </summary>
    public class Room
        {

            private float Luxury; // Пометка Люкс
            private int Square; // Площадь
            private float Price; // Стоимость проживания в сутки

        /// <summary>
        /// Метод инициализации данных номера отеля.
        /// </summary>
        /// <param name="S"> Площадь номера</param>
        /// <param name="P"> Цена номера</param>
        /// <param name="L"> Пометка Люкс для номера (0 или 1)</param>
        public void Init(int S, float P, float L) // инициализация площади и стоимости
            {
                Square = S;
                Price = P;
                Luxury = L;
                if (Square <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Square));
                }
                if (Price < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Price));
                }
                if ((Luxury != 0) && (Luxury != 1))
                {
                    throw new ArgumentOutOfRangeException(nameof(Luxury));
                }
            }

        /// <summary>
        /// Метод чтения с консоли данных о номере.
        /// </summary>
        public void Read()
            {
                Console.WriteLine("Введите площадь: ");
                Square = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите стоимость проживания за сутки: ");
                Price = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите 0 или 1 (Люкс): ");
                Luxury = float.Parse(Console.ReadLine());
            }

        /// <summary>
        /// Метод отображения в консоли данных об отеле с двумя номерами.
        /// </summary>
        public void Display()
            { 
                Console.WriteLine("Площадь номера: " + Square + "; " + "Стоимость проживания: " + Price);
                if (Luxury == 1)
                {
                    Console.WriteLine("Вид номера: Люкс");
                }
                else Console.WriteLine("Вид номера: обычный");
            }

        /// <summary>
        /// Метод посчёта привлекательности номера.
        /// </summary>
        /// <returns>
        /// Метод использует поля класса Price и Square и высчитывает 
        /// привлекательность номера по типу Цена/Площадь. 
        /// Получается цена за 1 м² - чем больше число, тем дороже.
        /// Данное отношение высчитывается по формуле:
        /// $$Attraction = Price * Square$$
        /// </returns>
        public float Attraction()
            { 
                return Price / Square;
            }


        /// <summary>
        /// Метод используется для передачи цены номера с учётом пометки Luxury. Если номер Люкс - цена умножается на 2.
        /// </summary>
        /// <returns>
        /// Метод возвращает полученную цену (Price).
        /// </returns>
        public float GetPrice()
            {
                if (Luxury == 1)
                {
                    return Price * 2;
                }
                return Price;
            }
        }
    }