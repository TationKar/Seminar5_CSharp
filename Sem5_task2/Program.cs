/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/
Console.Clear();
Console.Clear();

string Check (int n)
{
    int[] arr = new int[10];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 11);
    }

    Console.Write("[" + String.Join(",", arr) + "]");
    
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n)
        {
            return "True";
        }
    }
    return "False";
}

Console.Write("num: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(" num: " + num + " -> " + Check(num));
