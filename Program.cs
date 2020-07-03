using System;

namespace App30
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] charArray = { 'a', 'a', 'a' };
            //charArray[1] = (char)(charArray[0] + 1);
            //charArray[2] = (char)(charArray[1] + 1);
            //Console.WriteLine(charArray[0].ToString() + charArray[1].ToString() + charArray[2].ToString());

            //string text = "aaa";
            //text[1] = (char)(text[0] + 1);
            //text[2] = (char)(text[1] + 1);
            //Console.WriteLine(text);//Notă: Când se modifică sau se interschimbă între ele caractere individuale ale unui text e recomandat ca textul să fie stocat într-o variabilă de tip char array.

            string input = Console.ReadLine();
            while (input != "stop" && input != "")
            {
                string inputType = "";
                bool onlyDigits = true;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > '9')
                        onlyDigits = false;
                }

                if (onlyDigits)
                {
                    inputType = "numar";
                }

                if (input == "true" || input == "false")
                {
                    inputType = "valoare booleana";
                }

                if (inputType == "")
                {
                    inputType = "text";
                }

                Console.WriteLine(inputType);
                input = Console.ReadLine();
            }
        }
    }
}
