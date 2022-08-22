// Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа: ");

int degree = Convert.ToInt32(Console.ReadLine());


int CountDegree(int number,int degree)
{

int mult = 1;

if(degree == 0)               //  в 0 степени
{
 return mult = 1;
}
if(degree == 1)                // в 1 степени
{
 return  mult = number;
}

if((number > 0 || number < 0) && degree > 0)  // расчет положительных(и отрицательных) чисел и степеней
{
int i = 1;

while(i <= degree)
{
      mult *= number;
      i++; 
}
}
if(number == 0)                  // при 0 значении
{
  return mult = 0;
}

return mult;
}


Console.WriteLine(CountDegree(number,degree));



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 Console.Write("Введите число: ");

 string? number = Console.ReadLine();

 int result = 0;

for(int i = 0; i < number!.Length; i++)
{
  result +=  Convert.ToInt32(number[i].ToString());
}

Console.WriteLine(result);



//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int[8];

Console.Write("[");

for (int i = 0; i < array.Length; i++)
 {
    array[i] = new Random().Next(0,100);

    if(i == 7)
    {
       Console.Write(array[i]);
       break;
    }

    Console.Write(array[i]  + ",");

 }

 Console.Write("]");