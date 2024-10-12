namespace AreaColculator
{
    internal class Program
    {
        static int Calculate(int x, int y, char operatorSymbol)
        {
            int answer = 0;
            switch (operatorSymbol)
            {
                case '+':
                    answer = x + y;
                    break;
                case '-':
                    answer = x - y;
                    break;
                case '*':
                    answer = x * y;
                    break;
                case '/':
                    if (y != 0)
                        answer = x / y;
                    else
                        Console.WriteLine("Sifira bolmek olmaz!!!!!");
                    break;
                default:
                    break;
            }

            return answer;

        }

        static int Power(int x, int y = 2)
        {
            int answer = 1;


            for (int i = 0; i < y; i++)
                answer *= x;


            return answer;
        }

        static string WriteFullName(string name)
        {
            return name;
        }

        static string WriteFullName(string name, string surname)
        {
            return surname + " " + name;
        }

        static string WriteFullName(string name, string surname, string fatherName)
        {
            return name[0] + "." + surname + " " + fatherName;
        }


        static void Main(string[] args)
        {
        }
    }
}
