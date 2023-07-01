/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int [] CreatArrey(int size, int min, int max)
{
    int []arrey =  new int[size];
    Random rand = new Random();
    for(int i =0; i<size; i++)
    {
        arrey[i] = rand.Next(min, max+1);
    }
    Console.WriteLine($"[{string.Join(", ", arrey)}]");
    return arrey;
}

int sumNumber(int [] arrey)
{
    int res = 0;
    int sum = 0;
    for(int i = 1; i<arrey.Length; i+=2)
    { 
        //int res = 0; 
        
        sum = sum + arrey[i];
        res = sum;
        
    }
   return res; 
}

int [] NewArrey = CreatArrey(8, 10, 30);
Console.WriteLine(NewArrey);
Console.WriteLine(sumNumber(NewArrey));
