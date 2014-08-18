using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PlamenMinkov_1201561022__FirstProject
{
    class Encod
    {
        public string text;
        string[] symbol = new string[]{"a", "b", "c", "d", "e", "f",
            "g", "h", "i", "j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
            "A", "B", "C", "D", "E", "F","G", "H", "I", "J","K","L","M","N","O","P","Q","R",
            "S","T","U","V","W","X","Y","Z",
            "а", "б", "в", "г", "д", "е","ж", "з", "и", "й","к","л","м","н","о","п","р","с",
            "т","у","ф","х","ч","ц","ш","щ","ь","ъ","ю","я",
            "А", "Б", "В", "Г", "Д", "Е","Ж", "З", "И", "Й","К","Л","М","Н","О","П","Р","С",
            "Т","У","Ф","Х","Ч","Ц","Ш","Щ","Ь","Ъ","Ю","Я","!",Convert.ToString('"'),
            "#","%","&","'",",","-","/",":",";","<","=",">","{","~","_","@","(",")","*","+",
            "?","|","^","№","§","$"};


        string[] numbers = new string[140];
        int br = 1000;

        public Encod()
        {
            this.text = "";
        }
        public Encod(string text)
        {
            this.text = text;
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string ToUTF()
        {
            Encoding enc = new UTF8Encoding(true, true);
            byte[] bytes = enc.GetBytes(text);
            string value2 = enc.GetString(bytes);
            return value2;
        }
        public string Enc()
        {
            for (int i = 0; i < symbol.Length; i++)
            {
                numbers[i] = Convert.ToString(br);
                br++;
            }
            string propEncodeString = string.Empty;
            string[] array = new string[text.Length];
            int counter = 0;
            foreach (var item in text)
            {
                array[counter] = Convert.ToString(item);
                counter++;
            }
            for (int i = 0; i < counter; i++)
            {
                switch (array[i])
                {
                    case "0": array[i] = "0999"; break;
                    case "1": array[i] = "0998"; break;
                    case "2": array[i] = "0997"; break;
                    case "3": array[i] = "0996"; break;
                    case "4": array[i] = "0995"; break;
                    case "5": array[i] = "0994"; break;
                    case "6": array[i] = "0993"; break;
                    case "7": array[i] = "0992"; break;
                    case "8": array[i] = "0991"; break;
                    case "9": array[i] = "0990"; break;
                };
            }

            for (int i = 0, len = symbol.Length; i < len; i++)
            {
                for (int j = 0, len1 = array.Length; j < len1; j++)
                {

                    if (array[j].Equals(symbol[i]))
                    {
                        array[j] = numbers[i];

                    }

                }
            }
            foreach (var item in array)
            {
                propEncodeString += Convert.ToString(item);
            }
            return propEncodeString;
        }
        public string Decode()
        {
            string propEncodeString = string.Empty;
            string[] array = new string[text.Length];
            int counter = 0;
            foreach (var item in text)
            {
                array[counter] = Convert.ToString(item);
                counter++;
            }


            List<string> numbers = new List<string>(new string[] { "0990", "0991", "0992",
            "0993","0994","0995","0996","0997","0998","0999"});
            int num = 9;
            foreach (var item in numbers)
            {
                text = Regex.Replace(text, Convert.ToString(item),
                    Convert.ToString(num));
                num--;
            }

            int count = 1000;
            foreach (var item in symbol)
            {
                text = Regex.Replace(text, Convert.ToString(count), Convert.ToString(item));
                count++;
            }
            return text;
        }
    }
}
