// Написать программу, которая выводит случайное число из отрезка от
// 10 до 99 и показывает наибольшую цифру данного числа.
/*
int FindBiggesDiget(int num)

{
    int max;

    int ed = num % 10;
    int dec = num / 10;

    if(ed > dec)
        max = ed;
    else
        max = dec;
    return max;
}

int number = new Random().Next(10, 100);
int biggestDigit = FindBiggesDiget(number);

Console.WriteLine($"The bigges digit of {number} is {biggestDigit}");
*/

// Написать программу, которая выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа.
/*
int TwuDiggitNumber(int num)
{

    int ed = num % 10;
    int dec = num / 100;

    int resalt = dec * 10 + ed;

    return resalt;
}

int number = new Random().Next(100, 1000);
int twuDigit = TwuDiggitNumber (number);
Console.WriteLine($"The bigges digit of {number} is {twuDigit}");
*/

// Написать программу, которая принимает на вход число N и 
// проверяет кратно ли оно A и B. 
/*
bool MultipleNumber(int number, int a, int b)
{
    bool result;

    if (number % a == 0 && number % b == 0)
    {
        result = true;
    }
    else
    {
        result = false;
    }
     return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите первый делитель: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй делитель: ");
int b = Convert.ToInt32(Console.ReadLine());

bool res = MultipleNumber(number, a, b);
Console.WriteLine(res);
*/
/*
int FindQuart(double x, double y)
{
    int quart = 0;

    if(x > 0 && y > 0) return 1;
    if(x < 0 && y < 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y > 0) return 4;

    return quart;

}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A({x},{y}) is on the {FindQuart(x,y)} quart");
*/