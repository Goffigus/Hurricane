using System;
using static System.Console;
class Hurricane
{
    static void Main()
    {
        int windSpeed;
        string inputWindSpeed;
        const int Max5 = 157;
        const int Max4 = 130;
        const int Max3 = 111;
        const int Max2 = 96;
        const int Max1 = 74;
        //string Units = "mph";
        WriteLine("What is the maximum sustained wind speed of the storm?");
        inputWindSpeed = ReadLine();
        windSpeed = Convert.ToInt32(inputWindSpeed);

        if (windSpeed >= Max5)
            WriteLine("This is a category 5 hurricane");
        else if (windSpeed >= Max4)
            WriteLine("This is a category 4 hurricane");
        else if (windSpeed >= Max3)
            WriteLine("This is a category 3 hurricane");
        else if (windSpeed >= Max2)
            WriteLine("This is a category 2 hurricane");
        else if (windSpeed >= Max1)
            WriteLine("This is a category 1 hurricane");
        else
            WriteLine("This is not a hurricane");
    }
}
