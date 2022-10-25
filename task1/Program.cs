// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] WriteArray(int m)
{
 int len = m;
 int [] array = new int [len];
 
 for(int i = 0; i < array.Length; i++)
 {
    System.Console.WriteLine($"Введите число (элемент массива) {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
 }
 return array;
}

System.Console.WriteLine("Какое количество чисел (элементов массива) вводим? M=  ");
int m = Convert.ToInt32(Console.ReadLine());
int [] arr = WriteArray(m);

int CountPossitivNumbers(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            count++;
        }
    }
    return count;
} 

int resalt = CountPossitivNumbers(arr);
System.Console.WriteLine($"Положительных чисел (элементов массива): {resalt}");

