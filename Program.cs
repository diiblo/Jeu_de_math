// See https://aka.ms/new-console-template for more information



class Program
{
    enum operationEnum
    {
        ADDITION = 1,
        DIVISION = 2,
        MULTIPLICATION = 3,
        SOUSTRACTION = 4
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        static bool PoserQuestions(int min, int max)
        {


            while (true)
            {
                Random random = new Random();


                int a = random.Next(min, max + 1);
                int b = random.Next(min, max + 1);
                operationEnum operation = (operationEnum) random.Next(1, 5);
                int operationResult;

                //if (operation == 1)
                //{
                //    operationResult = a + b;
                //}
                //else if (operation == 2)
                //{
                //    operationResult = a / b;
                //}
                //else if (operation == 3)
                //{
                //    operationResult = a * b;
                //}

                switch (operation)
                {
                    case operationEnum.ADDITION:
                        operationResult = a + b;
                        Console.Write($"{a} + {b} = ");
                        break;
                    case operationEnum.DIVISION:
                        operationResult = a / b;
                        Console.Write($"{a} / {b} = ");
                        break;
                    case operationEnum.MULTIPLICATION:
                        operationResult = a * b;
                        Console.Write($"{a} * {b} = ");
                        break;
                    case operationEnum.SOUSTRACTION:
                        operationResult = a - b;
                        Console.Write($"{a} - {b} = ");
                        break;
                    default:
                        Console.Write("Erreur de choix");
                        return false;
                }

                try
                {
                    int reponseUser = int.Parse(Console.ReadLine());

                    if (operationResult == reponseUser)
                    {
                        return true;
                    }

                    return false;

                }
                catch
                {
                    Console.WriteLine("Réponse incorrecte");
                }

            }
        }


        const int maxNumber = 10;
        const int minNumber = 1;
        const int questionNumber = 3;

        int nombreDePoint = 0;

        for (int i = 0; i < questionNumber; i++)
        {
            Console.WriteLine($"Question {(i + 1)}/{questionNumber}");
            bool reponse = PoserQuestions(minNumber, maxNumber);

            if (reponse)
            {
                Console.WriteLine("Vous avez trouvez la bonne réponse");
                nombreDePoint++;
            }
            else
            {
                Console.WriteLine("Vous avez ratez");
            }

            Console.WriteLine("---------------------");
        }

        Console.WriteLine($"Votre nombre total de point est de {nombreDePoint}/{questionNumber}\n");

        if (nombreDePoint == questionNumber)
        {
            Console.WriteLine("Bravo vous avez trouvé toute les réponses");
        }
        else if (nombreDePoint == 0)
        {
            Console.WriteLine("Veuillez reviser vos cours de math");
        }
        else if (nombreDePoint > (questionNumber / 2))
        {
            Console.WriteLine("Pas mal");
        }
        else if (nombreDePoint <= (questionNumber / 2))
        {
            Console.WriteLine("Peut faire mieux. Courage");
        }
    }

}


