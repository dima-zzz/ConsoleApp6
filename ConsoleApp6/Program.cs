using System;
using System.Windows.Forms;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
          Написати консольну програму з такими методами(використовувати консоль для виводу результатів)*/

        }
        //-метод з оголошеними всіма типами примітивів та їх ініціалізацією
        public static void allPrimitivesTypesDeclarationInitialization()
        {
            byte a = new byte();
            a = byte.MaxValue;
            sbyte b = 0;
            b = sbyte.MinValue;
            int c = new int();
            c = int.MinValue;
            uint d = new uint();
            d = uint.MaxValue;
            short e = new short();
            e = short.MinValue;
            ushort f = new ushort();
            f = ushort.MaxValue;
            long g = new long();
            g = long.MinValue;
            ulong h = new ulong();
            h = ulong.MaxValue;
            float i = new float();
            i = float.MinValue;
            double j = new double();
            j = double.MinValue;
            decimal k = new decimal();
            k = decimal.MaxValue;
            char l = new char();
            l = 'T';
            char[] charArr = { 'A', 'b', 'c' };
            string m = new string(charArr, 1, 3);
            Console.Read();


        }
        //    - приведення типів для всіх примітивів(явне і неявне)
        //- метод з використанням всіх можливостей що пропонує System.String
        public static void AllStringMethods()
        {
            String s = "first book about c#";
            String c = "ABCDabcd";
            Console.WriteLine(" string \"{0}\" is empty: {1}", s, s== String.Empty);
            Console.WriteLine("Compare of strings \"{0}\" and \"{1}\" result: ", s, c, String.Compare(s, c));
            Console.WriteLine("CompareOrdinal of strings \"{0}\" and \"{1}\" result: ", s, c, String.CompareOrdinal(s, 6, c, 5, 1));
            String res = String.Concat(c, s);
            Console.WriteLine("Result of concat " + res);
            //String.Concat
            Console.WriteLine("Equals of strings \"{0}\" and \"{1}\" result: ", s, c, s.Equals(c));
            String StFm = String.Format("Civilization started in {0} or {1} or {2}", "Egypt", "India", "Africa");
            Console.WriteLine(StFm);
            Console.WriteLine(s.GetHashCode());
            String st1 = String.Intern("ABCDabcd");
            String st2 = (String)st1.Clone();
            Console.WriteLine(st1.CompareTo(st2));
            String st3 = st2.ToLower();
            st2 = st2.Substring(0, 4);
            st2.Insert(0, "I know such letters: ");
            st1.Remove(0, 5);
            st1.Replace(" book", " from book");
            st1.Split(" ");
        }
        //- метод з щонайменше п'ятьма типами з використанням їх методів що наслідують від System.Object
        public static void ObjectMethods()
        {
            object r = new object();
            Console.WriteLine( r.Equals(4));
            Console.WriteLine(r.GetType());
            Console.WriteLine(r.ToString());
            Console.WriteLine(r.GetHashCode());

            int i = 0;
            Console.WriteLine("i = " + i);
            i.Equals(1);
            int a = 0;
            int hashI = i.GetHashCode();
            int hashA = a.GetHashCode();
            Console.WriteLine("Compare hash codes: " + hashI.Equals(hashA));
            Console.WriteLine("Type: " + i.GetType() + "  to string: " + i.ToString());

            decimal d = 10.2M;
            decimal g = 10.2M;
            d.Equals(g);
            Type typeD = d.GetType();
            Type typeG = g.GetType();
            Console.WriteLine(" types of dd and g are equal: " + typeD.Equals(typeG));
            String StringD = d.ToString();
            String StringG = g.ToString();
            Console.WriteLine(" types of dd and g are equal: " + StringD.Equals(StringG));
            Console.WriteLine(d.GetHashCode());

            char t = 'a';
            Console.WriteLine("Type of 't':"+t.GetType());
            Console.WriteLine("hash code of 't':" + t.GetHashCode());
            Console.WriteLine("ToString of 't':" + t.ToString());
            char t2 = 'a';
            Console.WriteLine("t and t2 are equal:" + t.Equals(t2));

            bool boo = false;
            Console.WriteLine(boo.ToString());
            Console.WriteLine(boo.GetHashCode());
            Console.WriteLine(boo.GetType());
            Console.WriteLine(boo.Equals(0));

        }

        //- написати п'ять методів з використанням var
        public static void MethodVar1()
        {

            var a = new char[] { 'a', 'b', 'c', 'd' };
            Console.WriteLine(a.Length);
        }
        public static void MethodVar2()
        {
            byte s = 10;
            var a = 10;
            Console.WriteLine(a.Equals(s));
        }
        public static void MethodVar3()
        {
            var a = "Some Text";
            Console.WriteLine(a.ToUpperInvariant());
        }
        public static void MethodVar4()
        {
            var a = new Object();
            a = 1f;
            Console.WriteLine(a.GetType());
        }
        public static void MethodVar5()
        {
            var a = Console.ReadLine();
            Console.WriteLine("String ends with char \"a " + a.EndsWith('a').ToString());
        }

        //- написати по 2 методи з використанням кожної c# конструкції (if else, switch, for, foreach, while, do while, checked, unchecked)*/
        public static void IfELse1()
        {
            Console.WriteLine("Enter name of operation symlob: \"start\" of \"end\" or another ");
            string c = Console.ReadLine();
            if (c == "start")
            {
                Console.WriteLine("Operation started!");
            }
            else if (c == "end")
            {
                Console.WriteLine("Operation ended");
            }
            else Console.WriteLine("you enter neither start no end name!");
        }

        public static void IfElse2()
        {
            Console.WriteLine("The weather is raining. Do you want to  go to street? Enter y or n");
            var answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("Take umbrela!");
            }
            else if (answer == "n") Console.WriteLine("watch movie at home");
            else { Console.WriteLine("Make your choice!"); }
        }

        public static void Switch1()
        {
            int numberOfDay = (int)DateTime.Today.DayOfWeek;
            switch (numberOfDay)
            {
                case 6:
                case 7:
                    Console.WriteLine("its weekend, take a rest!");
                    break;
                default:
                    Console.WriteLine("Its working day");
                    break;
            }
        }

        public static void Switch2()
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            TimeSpan combo1 = new TimeSpan(12, 34, 56);
            TimeSpan combo2 = new TimeSpan(0, 0, 0);
            switch (time)
            {
                case combo1:
                case combo2:
                    Console.WriteLine("Magic time!");
                    break;
                default:
                    Console.WriteLine("Average time");
                    break;
            }
        }
        public static void For1()
        {
            for (int i = 0; i < 100; i += 4)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine("divide on ten!");
                }
            }
        }

        public static void For2()
        {
            char[] charArr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            char[] char2 = { 'a', 'e', 'i' };
            for (int i = 0; i < charArr.Length; i++)
            {
                if (Array.IndexOf(char2, charArr[i]) >= 0) { Console.WriteLine("vowel  letter!"); }
            }
        }

        public static void ForEach1()
        {
            String[] names = { "John", "Peter", "ALibaba" };
            foreach (string name in names)
            {
                Console.WriteLine("The name is {0}", name);
            }
        }

        public static void ForEach2()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach (int number in numbers)
            {
                bool dividesOnThree = number % 3 == 0;
                Console.WriteLine(" number " + number.ToString() + " divides of three: " + dividesOnThree);
            }
        }

        public static void While1()
        {
        string [] animals = { "wolf", "fox", "rabbit", "han" };
            int indexOfDomestic = Array.IndexOf(animals, "han");
            Console.WriteLine("Huess number of domestic animal, 1-4:");
            int numberEntered = int.Parse(Console.ReadLine()) - 1;
            while (indexOfDomestic != numberEntered)
            {
                Console.WriteLine("Not correct, try again");
                Console.WriteLine("Huess number of domestic animal, 1-4:");
            }
            Console.WriteLine("You uessed right!");
        }

        public static void While2()
        {
            int i = 0;
            while (i<10)
            {
                i++;
            }
            Console.WriteLine(i);
        }

        public static void DoWhile1()
        {
            string nameUser = "";
            Console.WriteLine("Enter user name: ");
            do
            {
                Console.WriteLine("To conrinue you need to authorizate with high access");
                nameUser = Console.ReadLine();
            } while (nameUser != "Admin");
            Console.WriteLine("You accessed!");
        }

        public static void DoWhile2()
        {
            int [] aArray = {1, 2, 3  };
            Random rand = new Random();
            do
            {
                int sizeArr = aArray.Length;
                aArray[sizeArr] = rand.Next(0, 9);
            } while (aArray.Length<10);
            Console.WriteLine("array size is 10 !");
        }

        public static void Checked1()
        {
            int a = 300;
            byte i = 0;
            checked
            {
                i = (byte)a;
            }
            Console.Write("all ok");
        }
        public static void Checked2()
        {
            int b = 100_000_000;
            byte i = 0;
            checked
            {
                i = (byte)b;
            }
            Console.Write("all ok");
        }

        public static void Unchecked()
        {
            byte a = 200;
            sbyte i = 0;
            unchecked
            {
                i = (sbyte)a;
            }
            Console.Write("all ok");
        }
    }


}
