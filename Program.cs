// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




// void PrintArray(int[] inArray)

// {
//     for(int i=0;i < inArray.Length;i++)
//     {
//         Console.Write($"{inArray[i]} ,");
//     }
// }

// int [] GEtArray(int size,int minValue,int maxValue)

// {
//     int[]res=new int [size];
//     for (int i=0;i<size;i++)
//     {
//         res[i]=new Random().Next(minValue,maxValue);
        
//     }
//     return res;
// }

// void number (int[] arr)
// {
//      int sum = 0;
//     for(int i=0;i<arr.Length;i++)
//         {
//             if(arr [i] % 2 == 0)
//             {
//                 sum++;
//              }
//         }
        
//         Console.WriteLine($" Количество чётных чисел {sum}" );
// }

// int[] array = GEtArray(6,101,999);
// PrintArray (array);
// number (array);


//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// void PrintArray(int[] inArray)

// {
//     for(int i=0;i < inArray.Length;i++)
//     {
//         Console.Write($"{inArray[i]} ,");
//     }
// }


// int [] GEtArray(int size,int minValue,int maxValue)

// {
//     int[]res=new int [size];
//     for (int i=0;i<size;i++)
//     {
//         res[i]=new Random().Next(minValue,maxValue);
        
//     }
//     return res;
// }


// void number (int[] arr)
// {
//      int sum = 0;
//     for(int i=0;i<arr.Length;i++)
//         {
//             if(i%2==1)
            
//             {
                
//             sum = sum + arr[i];
//             }
//         }
        
//         Console.WriteLine($" Сума чисел нечётных позиций {sum}" );
// }

// int[] array = GEtArray(6,1,50);
// PrintArray (array);
// number (array);

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3 7 22 2 78] -> 76


void PrintArray(double[] inArray)

{
    for(int i=0;i < inArray.Length;i++)
    {
        Console.Write($"{inArray[i]} ,");
    }
}




void number3(int [] arr)
{
    double m=0;
    int max = arr[0];
    int min = arr[0];
    for(int i=0;i<arr.Length;i++)
    {
        if(max<arr[i])
        {
            max = arr[i];
        }
        if(min>arr[i])
        {
            min=arr[i];
        }

    }

    m=max-min;
    Console.WriteLine($"Разница чисел{m}");
}

double [] GEtArray(int size,int minValue,int maxValue)

{
    double[]res=new double [size];
    for (int i=0;i<size;i++)
    {
        res[i]=new Random().Next(minValue,maxValue);
        
    }
    return res;
}

double[] array = GEtArray(6,1,50);
PrintArray (array);
number3(array);