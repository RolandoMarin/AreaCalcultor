// See https://aka.ms/new-console-template for more information
using MarinAreaCalculator;
using System.Text.RegularExpressions;

//startup project
    menu();
   static void menu()
{

    ConsoleKeyInfo userInput;
    do
    {
        Console.WriteLine("Choose a shape:");
        Console.WriteLine("1.Get area of a square:");
        Console.WriteLine("2.Get area of a rectangle:");
        Console.WriteLine("3.Get area of a triangle:");
        Console.WriteLine("4.Get area pf a parrallelogram;");
        Console.WriteLine("5.Get raduis of a circle:");
        Console.WriteLine("6.Get diaater of a circle:");
        Console.WriteLine("7.Exit:");
        userInput = Console.ReadKey();

        Console.WriteLine("");
        Console.Clear();
        validateInput_AndArea(userInput);
        
    }while(userInput.Key != ConsoleKey.D7 && userInput.Key != ConsoleKey.NumPad7);
}


static void validateInput_AndArea(ConsoleKeyInfo testInput)
{
   AreaCalc areaCalc = new AreaCalc();
    int ConvertedHeight;
    int ConvertedWidth;
    if (!Regex.Match(testInput.Key.ToString(), ".*[1-7].*").Success)
    {
        Bad_Input(testInput);
    }
    else if(testInput.Key == ConsoleKey.D1 ||testInput.Key == ConsoleKey.NumPad1){
        Console.WriteLine("enter a width please:");
        string NotConvertedWidth = Console.ReadLine();
        Console.WriteLine("enter a height please");
        string NotConvertedHeight = Console.ReadLine();
        Is_Square_string(NotConvertedHeight, NotConvertedWidth, areaCalc);
        press_Key();
    }
    else if (testInput.Key ==ConsoleKey.D2|| testInput.Key == ConsoleKey.NumPad2)
    {
        Console.WriteLine("enter a width please:");
        ConvertedWidth = Convert_string_int(Console.ReadLine());
        Console.WriteLine("enter a height please");
        ConvertedHeight = Convert_string_int(Console.ReadLine());
       if(ConvertedWidth != -1 || ConvertedHeight != 0)
        {
            Console.WriteLine("The area is :" + areaCalc.getRectangleArea(ConvertedWidth, ConvertedHeight));

        }
        else
        {
            Console.WriteLine("something went wrong");
        }
        press_Key();

    }

    else if(testInput.Key==ConsoleKey.D3 || testInput.Key == ConsoleKey.NumPad3)
    {
        Console.WriteLine("enter a width please:");
        ConvertedWidth = Convert_string_int(Console.ReadLine());
        Console.WriteLine("enter a height please");
        ConvertedHeight = Convert_string_int(Console.ReadLine());
        if (ConvertedWidth != -1 || ConvertedHeight != 0)
        {
            Console.WriteLine("The area is :" + areaCalc.getTriangleArea(ConvertedWidth, ConvertedHeight));

        }
        else
        {
            Console.WriteLine("something went wrong");
        }
        press_Key();
    }
    else if (testInput.Key == ConsoleKey.D4 || testInput.Key == ConsoleKey.NumPad4)
    {
        Console.WriteLine("enter a width please:");
        ConvertedWidth = Convert_string_int(Console.ReadLine());
        Console.WriteLine("enter a height please");
        ConvertedHeight = Convert_string_int(Console.ReadLine());
        if (ConvertedWidth != -1 || ConvertedHeight != 0)
        {
            Console.WriteLine("The area is :" + areaCalc.getParrallelogramArea(ConvertedWidth, ConvertedHeight));

        }
        else
        {
            Console.WriteLine("something went wrong");
        }
        press_Key();
    }
    else if (testInput.Key == ConsoleKey.D5 || testInput.Key == ConsoleKey.NumPad5)
    {
        Console.WriteLine("enter a Circumference please:");
        int convertedCirc = Convert_string_int(Console.ReadLine());
           
        if (convertedCirc != -1 )
        {
            Console.WriteLine("The Radius is :" + areaCalc.getCircleRadius(convertedCirc));

        }
        else
        {
            Console.WriteLine("something went wrong");
        }
        press_Key();
    }
    else if (testInput.Key == ConsoleKey.D5 || testInput.Key == ConsoleKey.NumPad5)
    {
        Console.WriteLine("enter a Circumference please:");
        int convertedCirc = Convert_string_int(Console.ReadLine());

        if (convertedCirc != -1)
        {
            Console.WriteLine("The diameter is :" + areaCalc.getCircleDiameter(convertedCirc));

        }
        else
        {
            Console.WriteLine("something went wrong");
        }
        press_Key();
    }

}

static void Bad_Input(ConsoleKeyInfo testInput)
{
    Console.WriteLine("Wrong! please try again");
    menu();
    ConsoleKeyInfo newKey = Console.ReadKey();
    Console.Clear();
}

static int Convert_string_int(string convertm)
{
    if (int.TryParse(convertm, out int firstResult) && !firstResult.ToString().Contains("-")){
        return firstResult;
    }
    else
    {
        return -1;
    }
}

static void press_Key()
{
    Console.WriteLine("press any key to return to menu");
        Console.ReadKey();
        Console.Clear();
}

static void Is_Square_string(string fValue , string sValue , AreaCalc areaCalc)
{
    if (int.TryParse(fValue, out int fRe) && int.TryParse(sValue, out int sRe))
    {
        Console.WriteLine("the area is: " + areaCalc.getSquareArea(fRe, sRe));
    }
    else
    {
        Console.WriteLine("the area is: " + areaCalc.getSquareArea(fValue, sValue));
    }
}