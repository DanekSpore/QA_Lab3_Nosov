using System;
using System.Collections.Generic;
using System.Text;

namespace QA_Lab3_Nosov
{
    /// \author Danil Nosov
    /// <summary>
    /// \brief Основной класс Hotel содержит информацию об отеле и ипспользует вспомогательный класс Room.
    /// </summary>
    /// \image html hotel.jpg
    /// \callergraph
    public class Hotel
        {

            private Room R1 = new Room(), R2 = new Room(); // 2 Номера
            private int Season; // Длительность сезона в днях

        /// <summary>
        /// Метод инициализации данных отеля с двумя номерами.
        /// </summary>
        /// <param name="S1"> Площадь первого номера</param>
        /// <param name="S2"> Площадь второго номера</param>
        /// <param name="P1"> Цена первого номера</param>
        /// <param name="P2"> Площадь второго номера</param>
        /// <param name="SD"> Длительность сезона отеля</param>
        /// <param name="L1"> Пометка Люкс для первого номера (0 или 1)</param>
        /// <param name="L2"> Пометка Люкс для второго номера (0 или 1)</param>
        public void Init(int S1, int S2, float P1, float P2, int SD, float L1, float L2)
            { // Инициализация данных отеля
                R1.Init(S1, P1, L1); // 1 номер
                R2.Init(S2, P2, L2); // 2 номер
                Season = SD;

                if (Season < 1)
                { // Длительность сезона должна быть больше 0
                    throw new ArgumentOutOfRangeException(nameof(Season));
                }
            }

        /// <summary>
        /// Метод чтения с консоли данных отеля с двумя номерами.
        /// </summary>
        public void Read() // Чтение данных с консоли об отеле
            {
                Console.WriteLine("Номер 1: ");
                R1.Read();
                Console.WriteLine("Номер 2: ");
                R2.Read();
                Console.WriteLine("Введите длительность сезона: ");
                Season = Convert.ToInt32(Console.ReadLine());
            }

        /// <summary>
        /// Метод отображения в консоли данных об отеле с двумя номерами.
        /// </summary>
        public void Display() // Вывод данных об отеле
            {
                Console.WriteLine("Номер 1: ");
                R1.Display();
                Console.WriteLine("Номер 2: ");
                R2.Display();
                Console.WriteLine("Длительность сезона: " + Season);
            }

        /// <summary>
        /// Метод посчёта ожидаемого дохода отеля за весь сезон.
        /// </summary>
        /// <returns>
        /// Метод использует поля класса Room и его метод GetPrice(),
        /// вследствие чего возвращает ожидаемый доход отеля, что 
        /// высчитывается по формуле:
        /// $$Income Expected = (Price_{1} + Price_{2}) * Season Duration$$
        /// </returns>

        public float TotalExpectedHotelIncomeForTheSeason() // Суммарный доход отеля за сезон
            {
                return (R1.GetPrice() + R2.GetPrice()) * Season;
            }

        /// <summary>
        /// Метод находит из двух номеров самый выгодный.
        /// </summary>
        /// <returns>
        /// Метод возвращает поле от вспомогательного класса, привлекательность которого выше, т. е. соотношение Цена/Площадь меньше.
        /// </returns>
        public Room TheMostAttractive() // Самый привлекательный номер
            {
                float Att1 = R1.Attraction(), Att2 = R2.Attraction();
                if (Att1 < Att2) // Если первый номер выгоднее
                {
                    return R1;
                }
                return R2;

            }
        }
    }

