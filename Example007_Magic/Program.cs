﻿//Console.Clear ();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while(count<10)
{ int what  = new Random().Net(0, 3);
if (what == 0);
{
        x = (x +xа)/2;
        y = (y +yа)/2;  
}

if (what == 1);
{
        x = (x +xb)/2;
        y = (y +yb)/2;  
}

if (what == 2);
{
        x = (x +xc)/2;
        y = (y +yc)/2;  
}

Console.SetCursorPosition(xa, ya);

Console.WriteLine("+");
count = count+1;
}