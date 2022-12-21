using System;
using System.Threading.Channels;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static string Encryption(string text)
        {
            string outText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'А' || text[i] == 'а')
                {
                    outText += "5788";
                }
                else if (text[i] == 'Б' || text[i] == 'б')
                {
                    outText += "1061";
                }
                else if (text[i] == 'В' || text[i] == 'в')
                {
                    outText += "9703";
                }
                else if (text[i] == 'Г' || text[i] == 'г')
                {
                    outText += "1010";
                }
                else if (text[i] == 'Д' || text[i] == 'д')
                {
                    outText += "1677";
                }
                else if (text[i] == 'Е' || text[i] == 'е')
                {
                    outText += "4483";
                }
                else if (text[i] == 'Ё' || text[i] == 'ё')
                {
                    outText += "8815";
                }
                else if (text[i] == 'Ж' || text[i] == 'ж')
                {
                    outText += "4694";
                }
                else if (text[i] == 'З' || text[i] == 'з')
                {
                    outText += "9916";
                }
                else if (text[i] == 'И' || text[i] == 'и')
                {
                    outText += "7649";
                }
                else if (text[i] == 'Й' || text[i] == 'й')
                {
                    outText += "1158";
                }
                else if (text[i] == 'К' || text[i] == 'к')
                {
                    outText += "5278";
                }
                else if (text[i] == 'Л' || text[i] == 'л')
                {
                    outText += "1683";
                }
                else if (text[i] == 'М' || text[i] == 'м')
                {
                    outText += "6252";
                }
                else if (text[i] == 'Н' || text[i] == 'н')
                {
                    outText += "8610";
                }
                else if (text[i] == 'О' || text[i] == 'о')
                {
                    outText += "7843";
                }
                else if (text[i] == 'П' || text[i] == 'п')
                {
                    outText += "5822";
                }
                else if (text[i] == 'Р' || text[i] == 'р')
                {
                    outText += "3721";
                }
                else if (text[i] == 'С' || text[i] == 'с')
                {
                    outText += "4233";
                }
                else if (text[i] == 'Т' || text[i] == 'т')
                {
                    outText += "3491";
                }
                else if (text[i] == 'У' || text[i] == 'у')
                {
                    outText += "9335";
                }
                else if (text[i] == 'Ф' || text[i] == 'ф')
                {
                    outText += "4609";
                }
                else if (text[i] == 'Х' || text[i] == 'х')
                {
                    outText += "1938";
                }
                else if (text[i] == 'Ц' || text[i] == 'ц')
                {
                    outText += "1368";
                }
                else if (text[i] == 'Ч' || text[i] == 'ч')
                {
                    outText += "3935";
                }
                else if (text[i] == 'Ш' || text[i] == 'ш')
                {
                    outText += "7121";
                }
                else if (text[i] == 'Щ' || text[i] == 'щ')
                {
                    outText += "8014";
                }
                else if (text[i] == 'Ъ' || text[i] == 'ъ')
                {
                    outText += "2208";
                }
                else if (text[i] == 'Ы' || text[i] == 'ы')
                {
                    outText += "6838";
                }
                else if (text[i] == 'Ь' || text[i] == 'ь')
                {
                    outText += "5245";
                }
                else if (text[i] == 'Э' || text[i] == 'э')
                {
                    outText += "6696";
                }
                else if (text[i] == 'Ю' || text[i] == 'ю')
                {
                    outText += "7886";
                }
                else if (text[i] == 'Я' || text[i] == 'я')
                {
                    outText += "4244";
                }
                else if (text[i] == ' ')
                {
                    outText += "0000";
                }
                else if (text[i] == '"')
                {
                    outText += "0001";
                }
                else if (text[i] == '.')
                {
                    outText += "0002";
                }
                else if (text[i] == ',')
                {
                    outText += "0003";
                }
                else if (text[i] == '!')
                {
                    outText += "0004";
                }
                else if (text[i] == '?')
                {
                    outText += "0005";
                }
            }
            return outText;
        }
        
        public static string Decoding(string text)
        {
            string outText = "";
            for (int i = 0; i < text.Length; i += 4)
            {
                if (text[i] == '5' && text[i+1] == '7' && text[i+2] == '8' && text[i+3] == '8')
                {
                    outText += "А";
                }
                else if (text[i] == '1' && text[i+1] == '0' && text[i+2] == '6' && text[i+3] == '1')
                {
                    outText += "Б";
                }
                else if (text[i] == '9' && text[i+1] == '7' && text[i+2] == '0' && text[i+3] == '3')
                {
                    outText += "В";
                }
                else if (text[i] == '1' && text[i+1] == '0' && text[i+2] == '1' && text[i+3] == '0')
                {
                    outText += "Г";
                }
                else if (text[i] == '1' && text[i+1] == '6' && text[i+2] == '7' && text[i+3] == '7')
                {
                    outText += "Д";
                }
                else if (text[i] == '4' && text[i+1] == '4' && text[i+2] == '8' && text[i+3] == '3')
                {
                    outText += "Е";
                }
                else if (text[i] == '8' && text[i+1] == '8' && text[i+2] == '1' && text[i+3] == '5')
                {
                    outText += "Ё";
                }
                else if (text[i] == '4' && text[i+1] == '6' && text[i+2] == '9' && text[i+3] == '4')
                {
                    outText += "Ж";
                }
                else if (text[i] == '9' && text[i+1] == '9' && text[i+2] == '1' && text[i+3] == '6')
                {
                    outText += "З";
                }
                else if (text[i] == '7' && text[i+1] == '6' && text[i+2] == '4' && text[i+3] == '9')
                {
                    outText += "И";
                }
                else if (text[i] == '1' && text[i+1] == '1' && text[i+2] == '5' && text[i+3] == '8')
                {
                    outText += "Й";
                }
                else if (text[i] == '5' && text[i+1] == '2' && text[i+2] == '7' && text[i+3] == '8')
                {
                    outText += "К";
                }
                else if (text[i] == '1' && text[i+1] == '6' && text[i+2] == '8' && text[i+3] == '3')
                {
                    outText += "Л";
                }
                else if (text[i] == '6' && text[i+1] == '2' && text[i+2] == '5' && text[i+3] == '2')
                {
                    outText += "М";
                }
                else if (text[i] == '8' && text[i+1] == '6' && text[i+2] == '1' && text[i+3] == '0')
                {
                    outText += "Н";
                }
                else if (text[i] == '7' && text[i+1] == '8' && text[i+2] == '4' && text[i+3] == '3')
                {
                    outText += "О";
                }
                else if (text[i] == '5' && text[i+1] == '8' && text[i+2] == '2' && text[i+3] == '2')
                {
                    outText += "П";
                }
                else if (text[i] == '3' && text[i+1] == '7' && text[i+2] == '2' && text[i+3] == '1')
                {
                    outText += "Р";
                }
                else if (text[i] == '4' && text[i+1] == '2' && text[i+2] == '3' && text[i+3] == '3')
                {
                    outText += "С";
                }
                else if (text[i] == '3' && text[i+1] == '4' && text[i+2] == '9' && text[i+3] == '1')
                {
                    outText += "Т";
                }
                else if (text[i] == '9' && text[i+1] == '3' && text[i+2] == '3' && text[i+3] == '5')
                {
                    outText += "У";
                }
                else if (text[i] == '4' && text[i+1] == '6' && text[i+2] == '0' && text[i+3] == '9')
                {
                    outText += "Ф";
                }
                else if (text[i] == '1' && text[i+1] == '9' && text[i+2] == '3' && text[i+3] == '8')
                {
                    outText += "Х";
                }
                else if (text[i] == '1' && text[i+1] == '3' && text[i+2] == '6' && text[i+3] == '8')
                {
                    outText += "Ц";
                }
                else if (text[i] == '3' && text[i+1] == '9' && text[i+2] == '3' && text[i+3] == '5')
                {
                    outText += "Ч";
                }
                else if (text[i] == '7' && text[i+1] == '1' && text[i+2] == '2' && text[i+3] == '1')
                {
                    outText += "Ш";
                }
                else if (text[i] == '8' && text[i+1] == '0' && text[i+2] == '1' && text[i+3] == '4')
                {
                    outText += "Щ";
                }
                else if (text[i] == '2' && text[i+1] == '2' && text[i+2] == '0' && text[i+3] == '8')
                {
                    outText += "Ъ";
                }
                else if (text[i] == '6' && text[i+1] == '8' && text[i+2] == '3' && text[i+3] == '8')
                {
                    outText += "Ы";
                }
                else if (text[i] == '5' && text[i+1] == '2' && text[i+2] == '4' && text[i+3] == '5')
                {
                    outText += "Ь";
                }
                else if (text[i] == '6' && text[i+1] == '6' && text[i+2] == '9' && text[i+3] == '6')
                {
                    outText += "Э";
                }
                else if (text[i] == '7' && text[i+1] == '8' && text[i+2] == '8' && text[i+3] == '6')
                {
                    outText += "Ю";
                }
                else if (text[i] == '4' && text[i+1] == '2' && text[i+2] == '4' && text[i+3] == '4')
                {
                    outText += "Я";
                }
                else if (text[i] == '0' && text[i+1] == '0' && text[i+2] == '0' && text[i+3] == '0')
                {
                    outText += " ";
                }
                else if (text[i] == '0' && text[i+1] == '0' && text[i+2] == '0' && text[i+3] == '1')
                {
                    outText += "'";
                }
                else if (text[i] == '0' && text[i+1] == '0' && text[i+2] == '0' && text[i+3] == '2')
                {
                    outText += ".";
                }
                else if (text[i] == '0' && text[i+1] == '0' && text[i+2] == '0' && text[i+3] == '3')
                {
                    outText += ",";
                }
                else if (text[i] == '0' && text[i+1] == '0' && text[i+2] == '0' && text[i+3] == '4')
                {
                    outText += "!";
                }
                else if (text[i] == '0' && text[i+1] == '0' && text[i+2] == '0' && text[i+3] == '5')
                {
                    outText += "?";
                }
                else
                {
                    outText += "_Ошибка_";
                }
            }
            return outText;
        }
        
        static void Main(string[] args)
        {
            bool work = true;
            while (work == true)
            {
                Console.WriteLine("Шифровщик текста!");
                string result;
                string result1;
                Console.WriteLine("Выберите действие:\n1. Защифровать.\n2. Расшифровать");
                string otv = Console.ReadLine();
                if (otv == "1")
                {
                    Console.Write("Введите тест для шифрования: ");
                    result = Console.ReadLine();
                    result1 = Encryption(result);
                    Console.WriteLine($"\n\nРезультат: \n{result1}\n\n");
                    result1 = "";
                }
                else if (otv == "2")
                {
                    Console.Write("Введите тест для расшифровки: ");
                    result = Console.ReadLine();
                    result1 = Decoding(result);
                    Console.WriteLine($"\n\nРезультат: \n{result1}\n\n");
                    result1 = "";
                }
                else
                {
                    Console.WriteLine("Такого результата нет!");
                }
                Console.WriteLine("Нажми любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}