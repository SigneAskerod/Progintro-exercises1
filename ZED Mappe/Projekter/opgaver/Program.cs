double Sqrt(double number)
{
    double guess = number / 2;

    for (int i = 0; i < 20; i++)
    {
        guess = (guess + number / guess) / 2;
    }

    return guess;
}

double result = Sqrt(25);

Console.WriteLine(result);