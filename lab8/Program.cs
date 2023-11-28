using System.Text;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringIterationDemo();
            //StringBuilderDemo();
            //StringInstanceMethodsDemo();
            //StringStaticMethodDemo();
            DateTimeDemo();
        }

        public static void DateTimeDemo()
        {
            DateTime date = DateTime.Now; //obecny czas
            Console.WriteLine(date);
            DateTime birth = new DateTime(2000, 10, 20, 22, 5, 0); //20.10.2000 22:05:00
            Console.WriteLine(birth);
            string stringDate = "2000-10-10";
            if (DateTime.TryParse(stringDate, out birth))
            {
                Console.WriteLine(birth);
            }
            else
            {
                Console.WriteLine("Niepoprawny format daty.");
            }
        }

        public static void StringStaticMethodDemo()
        {
            string[] names = { "adam", "ewa", "karol" };
            Console.WriteLine(string.Concat(names));
            Console.WriteLine(string.Join(", ", names));
            string a1 = "abc";
            string a2 = "bc";
            Console.WriteLine(string.Compare(a1, a2)); // -1 -> a1 > a2, 1 -> a1 < a2, 0 -> a1 == a2
            if(a1 == a2)
            {
                Console.WriteLine("identyczne");
            }
            else
            {
                Console.WriteLine("różne");
            }
        }

        public static void StringInstanceMethodsDemo()
        {
            Console.WriteLine("abcd".ToUpper());
            Console.WriteLine("aDEcd".ToLower());
            Console.WriteLine("agbNJRG".IndexOf('N'));
            Console.WriteLine("agbNJRG".LastIndexOf('N'));
            Console.WriteLine("geibIGEBgiege".Substring(1, 3));
            string emailAddress = "adam@wsei.edu.pl";

            string emailDomain = emailAddress.Substring(emailAddress.IndexOf('@') + 1, emailAddress.Length - (emailAddress.IndexOf('@') + 1));
            //LUB
            string emailDomain2 = emailAddress.Substring(emailAddress.IndexOf('@') + 1); //do końca
            Console.WriteLine(emailDomain);
            Console.WriteLine(emailDomain2);

            string[] tokens = emailAddress.Split("@");
            foreach(string token in tokens)
            {
                Console.WriteLine(token);
            }

            string input = "12 56 567 89";
            string[] inputArray = input.Split(" ");
            int[] values = new int[inputArray.Length];
            for(int i = 0; i < inputArray.Length; i++)
            {
                values[i] = int.Parse(inputArray[i]);
            }
            foreach(int val in values)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("   bez spacji  ".Trim()); //usuwa z początku i z końca
            Console.WriteLine("abcd".Insert(1, "22"));
            Console.WriteLine("abcd".Replace("ab", "22"));
            Console.WriteLine("   bez  spacji  ".Trim().Replace(" ", ""));
            Console.WriteLine("abcd".StartsWith("ab"));
            Console.WriteLine("abcd".EndsWith("cd"));

            string msg = "Opcja 1";
            switch (msg)
            {
                case "Opcja 1":
                    Console.WriteLine("Wybrano opcję nr 1");
                    break;
                case "Opcja 2":
                    Console.WriteLine("Wybrano opcję nr 2");
                    break;
                case "Opcja 3":
                    Console.WriteLine("Wybrano opcję nr 3");
                    break;
            }
        }

        public static void StringBuilderDemo()
        {
            string msg = "abcdefg";
            StringBuilder sb = new StringBuilder();
            foreach(char znak in msg)
            {
                sb.Append((char)(znak + 10));
            }
            Console.WriteLine(sb);
            Console.WriteLine(sb.ToString());
        }

        public static void StringIterationDemo()
        {
            string msg = "abcdefgh";
            string result = "";
            for(int i = 0; i < msg.Length; i++)
            {
                char znak = msg[i];
                result += (char)(znak + 10);
                //msg[i] = 'a' BŁĄD: nie można zmienić znaku w łańcuchu
            }
            Console.WriteLine(result);
        }

        public static void StringCreationDemo()
        {
            string message = "Komunikat";
            string messageInterpolated = $"Treść komunikatu: {message}";
            string messageEscaped = @"c:\data\file.txt";
            string messageConcatenated = message + ", " + messageEscaped + 1 + 1; //Komunikat, c:\data\file.txt11
            //Console.WriteLine(messageConcatenated);
            //Console.WriteLine($"{message}, {messageEscaped}{1+1}"); Komunikat, c:\data\file.txt2

            char[] chars = { 'a', 'b', 'c' };
            string abc = new String(chars); //lub z małej->  new string(chars)
            Console.WriteLine(abc);
        }

    }
}