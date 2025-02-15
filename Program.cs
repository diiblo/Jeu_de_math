// See https://aka.ms/new-console-template for more information

static bool poserQuestions(int min, int max)
{
    Random random = new Random();


    int a = random.Next(min, max + 1);
    int b = random.Next(min, max + 1);

    while (true)
    {

        Console.Write($"{a} + {b} = ");

        try
        {
            int reponseUser = int.Parse(Console.ReadLine());

            if ((a + b) == reponseUser)
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


const int MAX_NUMBER = 10;
const int MIN_NUMBER = 1;
const int QUESTION_NUMBER = 3;

int nombre_de_point = 0;

for (int i = 0; i < QUESTION_NUMBER; i++)
{
    Console.WriteLine($"Question {(i + 1)}/{QUESTION_NUMBER}");
    bool reponse = poserQuestions(MIN_NUMBER, MAX_NUMBER);

    if (reponse)
    {
        Console.WriteLine("Vous avez trouvez la bonne réponse");
        nombre_de_point++;
    }
    else
    {
        Console.WriteLine("Vous avez ratez");
    }

    Console.WriteLine("---------------------");
}

Console.WriteLine($"Votre nombre total de point est de {nombre_de_point}/{QUESTION_NUMBER}\n");

if (nombre_de_point == QUESTION_NUMBER)
{
    Console.WriteLine("Bravo vous avez trouvé toute les réponses");
}
else if (nombre_de_point == 0)
{
    Console.WriteLine("Veuillez reviser vos cours de math");
}
else if (nombre_de_point > (QUESTION_NUMBER / 2))
{
    Console.WriteLine("Pas mal");
}
else if (nombre_de_point <= (QUESTION_NUMBER / 2))
{
    Console.WriteLine("Peut faire mieux. Courage");
}
