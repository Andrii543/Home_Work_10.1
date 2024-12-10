using System.Text;

namespace Home_Wokr_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;


            Console.Write("Введіть своє ім'я та прізвище (через пробіл): ");
            string fullName = Console.ReadLine().Trim();  // Вводимо ім'я та прізвище в один рядок з пробілом 

            // Знаходимо першу літеру імені та прізвища без масиву
            char firstLetterFirstName = fullName[0];  // Перша літера імені
            char firstLetterLastName = fullName.Split(' ')[1][0];  // Розділяємо рядок за пробілом на два слова потім беремо першу літеру прізвища тобто другого слова

            // Порівнюємо перші літери
            if (char.ToLower(firstLetterFirstName) == char.ToLower(firstLetterLastName))
            {
                Console.WriteLine($"Прізвище починається на ту ж літеру, що і ім'я:\nПерша літера ім'я {firstLetterFirstName}\nПерша літера прізвища {firstLetterLastName}");
            }
            else
            {
                Console.WriteLine($"Прізвище не починається на ту ж літеру, що і ім'я:\nПерша літера ім'я {firstLetterFirstName}\nПерша літера прізвища {firstLetterLastName}");
            }
        }
    }
}
