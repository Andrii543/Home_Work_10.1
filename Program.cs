using System.Text;

namespace Home_Wokr_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;


            //Я зробив два різних вивода
            //1: Це коли ми вписуєм ім'я та прізвище тобто коли ми незнаєм що користувач введе
            //2: Це коли ми знаєм що знаходиться під зміннами ім'я та прізвища 


            // 1 Спосіб
            Console.Write("Введіть своє ім'я: ");
            string inputFistName = Console.ReadLine();

            Console.Write("Введіть своє Прізвище: ");
            string inputLastName = Console.ReadLine();


            string fistLaterName = inputFistName.Substring(0, 1);
            string firstLaterLastName = inputLastName.Substring(0, 1);

            if (fistLaterName == firstLaterLastName)
            {
                Console.WriteLine($"Прізвище починається на ту ж літеру, що і ім'я:\nПерша літера ім'я {fistLaterName}\nПерша літера прізвища {firstLaterLastName}");
            }
            else
            {
                Console.WriteLine($"Прізвище не починається на ту ж літеру, що і ім'я:\nПерша літера ім'я {fistLaterName}\nПерша літера прізвища {firstLaterLastName}");
            }


            // 2 Спосіб
            string name = "Andrew";
            string lastName = "Rusyn";


            string removeName = name.Remove(1, 5);
            string removeLastName = lastName.Remove(1, 4);

            if (removeName == removeLastName)
            {
                Console.WriteLine($"Прізвище починається на ту ж літеру, що і ім'я:\nПерша літера ім'я {removeName}\nПерша літера прізвища {removeLastName}");
            }
            else
            {
                Console.WriteLine($"Прізвище не починається на ту ж літеру, що і ім'я:\nПерша літера ім'я {removeName}\nПерша літера прізвища {removeLastName}");
            }

        }
    }
}
