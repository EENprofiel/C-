namespace Les1poging2;

public class Opdracht8
{
    public static void Execute()
    {
        for (int i = 1; i < 50; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}