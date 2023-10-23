using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ОпрограммеClick(object sender, RoutedEventArgs e) //Кнопка "О программе"
        {
            MessageBox.Show("Разработчик: Мелехин Дмитрий. Задание: Вычислить сумму целых случайных чисел, распределенных в диапазоне от 2 до 10,пока эта сумма не превышает некоторого числа K.Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел");
        }

        private void ВыходClick(object sender, RoutedEventArgs e) //Кнопка "Выход"
        {
            this.Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e) //Кнопка "Вывести числа"
        {
            bool f1 = int.TryParse(zn1.Text, out int K);
            if (f1 == true) //проверка числа
            {
                if (K > 0)//подходит ли число условию
                {
                    string manyvalue; //объявляем переменную
                    WpfLibrary1.Class1.GetSum(K, out int sum, out int kol, out manyvalue); //используем библиотеку классов
                    zn2.Text = zn2.Text + " " + manyvalue.ToString(); //выводим сгенерированные числа
                    zn3.Text = sum.ToString(); //выводим сумму
                    zn4.Text = kol.ToString(); //выводим кол-во сгенерированных чисел
                }
                else
                    MessageBox.Show("Введите число больше 0");
            }
            else
                MessageBox.Show("Я люблю числа, а не буквы");
        }

        private void Button2_Click(object sender, RoutedEventArgs e) //Кнопка "Очистить"
        {
            zn1.Clear();
            zn2.Clear();
            zn3.Clear();
            zn4.Clear();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Купил мужик шляпу, а она ему как раз");
        }
    }
}
