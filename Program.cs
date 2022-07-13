/*
int DelNumber(int num)
{
    int first  = num / 100;
    int second = num % 10;

    int newnumber = first*10+second;

    return newnumber;
} 


int number = new Random().Next(100,999);
int num2 = DelNumber(number); 

Console.WriteLine(number);
Console.WriteLine(num2);


//Напишите программу, которая принимает на вход число и опроверяет его кратно ли оно одновременно 7 и 23. 

int Crat(int num)
{
    if (num%7==0||num%23==0)
    {
        int res = num;            
        return res;
    }
    else 
        int res2 = num;


}

int num2 = 27;

int res = Crat(num2);
Console.WriteLine(res);
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

bool Den(int num)
{
    if (num == 6 || num == 7)
        return true;
    else return false;
}
 
Console.Write("Введите день недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool dn = Den(number);

if (number>7 || number<1)
    Console.WriteLine("Число не соответствует заданному диапазону!"); 
else if (dn==true)
    Console.WriteLine("Да, день выходной!");
else
    Console.WriteLine("Нет, не выходной");    