// string[,] table = new string[2,5];
// // String.Empty - инициализация строк
// // table[0,0]   table[0,1] table[0,2] table[0,3] table[0,4] 
// // table[1,0]   table[1,1] table[1,2] table[1,3] table[1,4]

// table[1,2] = "слово"; // обращение к элементу массива (к 1 строке, 2 столбцу)

// for (int rows = 0; rows < 2; rows++) // rows переводится как "строки"
// {
//     for (int columns = 0; columns < 5; columns++) // columns - столбцы
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }




void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // интервал от 1 до 9 ( [1,10) ) 
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix); // сначала напечатали пустой массив
Console.WriteLine();

FillArray(matrix); // заполнили массив псевдослучайными числами
PrintArray(matrix); // теперь напечатали уже заполненый массив