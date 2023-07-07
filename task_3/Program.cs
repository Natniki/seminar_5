
// Задайте массив вещественных чисел.
 // Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


//float [] CreatArrey(int size, int min, int max)
//{
    double [] arrey =  new double[15];
    Random rand = new Random();
    for(int i =0; i<arrey.Length; i++)
    {
        arrey[i] = rand.NextDouble()*(23-22)+22;
        
    }
    Console.WriteLine($"[{string.Join(", ", arrey)}]");
    //return arrey;
//}

//float [] NewArrey = CreatArrey(8, 0, 1);