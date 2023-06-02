/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]  String.Join(", ", array)*/
Console.Clear();

int[] arr = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }
            

    Console.WriteLine("[" + string.Join("\t", arr) + "]");

    for (int i = 0;i < arr.Length; i++)
{
    arr[i] *= -1;
}
            
Console.WriteLine("[" + string.Join("\t", arr) + "]");