// Вид 1
void Method1()
{
    Console.WriteLine("Автор..");
}

// Method1(); // Так вызывается этот метод

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2(msg: "Текст сообщения"); // msg: - для того чтобы определить к какому аргументу метода присвоить данный входящий аргумент

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Новый текст");


// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);



// Вид 4


// string Method4(int count, string text) // char тип данных, предназначенный для хранения одного символа
// {
//     int i = 0;
//     string result = String.Empty; // переменная изначально будет пустой строкой

//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, " asdf ");
// Console.WriteLine(res);

string Method4(int count, string text) // char тип данных, предназначенный для хранения одного символа
{
    string result = String.Empty; // переменная изначально будет пустой строкой

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, " asdf ");
// Console.WriteLine(res); 




//цикл в цикле
// вывод таблицы умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10 ; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }



//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

// Ясна ли задача?


string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwert"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если текущий символ (text[i]) совпал с тем символом который мы хотим заменить (oldValue) то в результат (result) мы должны будем положить новое значение строки (newValue)
        else result = result + $"{text[i]}"; // иначе (если не совпал) то положить текущий символ (тот что и был)
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);











