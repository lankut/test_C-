/*Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int xa=20;
int ya=1;
int xb=1;
int yb=20;
int xc=40;
int yc=20;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = xb; 
int count = 0;
while (count<100) 
{
    int what=new Random().Next(0,3);
    if (what == 0)
    {
       x=(x+xa)/2;
       y=(y+ya)/2;
    }
    if (what == 1)
    {
       x=(x+xb)/2;
       y=(y+yb)/2;
    }
    if (what == 2)
    {
       x=(x+xc)/2;
       y=(y+yc)/2;
    }
Console.SetCursorPosition(x,y);
Console.WriteLine("+");
count=count+1;
}
*/
//Задача №2
/*
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
   Console.WriteLine("Большее число "+number1+" меньшее число"+number2);
if (number1<number2)
   Console.WriteLine("Большее число "+number2+" меньшее число"+number1);
if (number1==number2)
   Console.WriteLine("Числа равны");
*/

//Задача №4
/*
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;

if (number1>number2)
   max = number1;   
else max = number2;
if (max<number3)
   max = number3;

Console.WriteLine("Максимальное число из трех цифр: "+max);
*/
//Задача 6

/*
Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2==0)
   Console.WriteLine("Да!");
else 
   Console.WriteLine("Нет");
*/

//Задача 8

/*Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<number1; i++)
{
   if (i % 2==0) 
      Console.WriteLine(i);   
}   
*/

Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
int start = 1;

while (start <= number1)
{
   if (start % 2==0)
       Console.WriteLine(start);   
   start++;
}
