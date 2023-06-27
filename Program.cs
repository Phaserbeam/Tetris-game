
//program execution starts from here

Console.WriteLine("Press any button to begin:");
Tetri.S fall = new()
{
    rotation = 1
};

fall.rotation = 2;
fall.rotation = 3;

int axis = 1;

if (3 - fall.rotation > 1)
{
    axis = 0;
}
for (int i = 0, x = 0; x < 4 || i < 16; i++)
{
    if (fall.hitboxes[axis, i] == fall.rotation || fall.hitboxes[axis, i] == 4)
    {
        x++;
        Console.Write("1");
    }
    else
    {
        Console.Write("0");
    }
}
Console.ReadLine();