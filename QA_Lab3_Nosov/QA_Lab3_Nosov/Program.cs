using System;

namespace QA_Lab3_Nosov
{
    /// \author Danil Nosov
    /// <summary>
    /// \brief Исполняемый класс программы с методом Main. Производится ввод данных и выводится соотвествующая информация.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Hotel A = new Hotel();
            Console.WriteLine("Гостиница: ");
            //A.Init(9, 20, (float)5000.0, (float)9999.99, 30, 0, 1);
            //A.Display();
            A.Read();
            A.Display();
            Room B = A.TheMostAttractive();
            Console.WriteLine("Ожидаемый доход гостиницы за сезон: " + A.TotalExpectedHotelIncomeForTheSeason() + "\nСамый привлекательный номер в гостинице: ");
            B.Display();
        }
    }
}
