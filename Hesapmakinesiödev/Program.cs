using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesapmakinesiödev
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, sonuc = -1;
            char operators;

            Console.Write("İlk sayıyı giriniz: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            number2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Operatörlere giriniz:  (toplam: +, çıkarma: - ,çarpma: *, bölme:/) ");
            operators = Console.ReadLine()[0];

            if (operators == '+')
            {
                sonuc = number1 + number2;
            }

            else if (operators == '-')
            {
                sonuc = number1 - number2;
            }
            else if (operators == '*')
            {
                sonuc = number1 * number2;
            }
            else // operators == /
            {
                sonuc = number1 / number2;
            }

            Console.WriteLine("{0} {1} {2} = {3}", number1, operators, number2, sonuc);
            Console.ReadLine();
        }
    }
}
