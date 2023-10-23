using System;

namespace WpfLibrary1
{
    public class Class1 //Имя класса
    {
        public static void GetSum(int K, out int sum, out int kol, out string manyvalue) //задаем значения
        {
            int value = 0;
            sum = 0; //сумма сгенерированных чисел
            kol = 0; //кол-во сгенерированны\ чисел
            manyvalue = ""; //генерируем числа
            Random rnd = new Random(); //генерируем числа с помощью рандома

            while (sum <= K) //цикл
            {
                value = rnd.Next(2, 10); //присваиваем значение рандомных значений
                sum += value; //перезаписываем значение и складываем
                manyvalue += value; //перезаписываем значение и выводим числа
                kol++; //счечтчик единиц
            }
        }
    }
}
