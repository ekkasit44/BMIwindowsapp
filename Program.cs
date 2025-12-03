
using System.Text;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            
            Console.WriteLine("กรอกน้ำหนัก");
            string weightInput = Console.ReadLine();
            double weight = double.Parse(weightInput);

            Console.WriteLine("กรอกส่วนสูง (เซนติเมตร)");

            string heightInput = Console.ReadLine();
            double height = double.Parse(heightInput);

            double heightM = height / 100.0;

            double bmi = weight / (heightM * heightM);
            Console.WriteLine("ค่าดัชนีมวลกาย (BMI) ของคุณคือ: " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("น้ำหนักน้อยเกินไป");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("น้ำหนักปกติ");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("น้ำหนักเกิน");
            }
            else
            {
                Console.WriteLine("อ้วน");
            }

        }
    }
}

