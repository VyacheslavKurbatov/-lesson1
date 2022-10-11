Console.Clear(); // чтобы очистить консоль перед началом 
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, xb = 1, //координаты исходных точек 
    ya = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); //координата которую надо нарисовать
Console.WriteLine("+"); //каким символом будет рисовать

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb; //задаем первые две точки

int count = 0; // колличество раз нахождения отрезков и деления их пополам

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2; // what1,2,3 определяет позицию середины между точками
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}