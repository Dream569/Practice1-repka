using System;

namespace WpfLibrary1
{
    public class Class1 //��� ������
    {
        public static void GetSum(int K, out int sum, out int kol, out string manyvalue) //������ ��������
        {
            int value = 0;
            sum = 0; //����� ��������������� �����
            kol = 0; //���-�� ��������������\ �����
            manyvalue = ""; //���������� �����
            Random rnd = new Random(); //���������� ����� � ������� �������

            while (sum <= K) //����
            {
                value = rnd.Next(2, 10); //����������� �������� ��������� ��������
                sum += value; //�������������� �������� � ����������
                manyvalue += value; //�������������� �������� � ������� �����
                kol++; //�������� ������
            }
        }
    }
}
