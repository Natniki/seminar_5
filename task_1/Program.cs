//: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2




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


int CountNumber(int [] arrey)
{
    int count = 0;
    for(int i = 0; i<arrey.Length; i++)
        if(i%2==0)
        {  
        count+=1;
        }
    return count;
}

int [] NewArrey = CreatArrey(12, 100, 1000);
Console.WriteLine(NewArrey);
Console.WriteLine(CountNumber(NewArrey));
