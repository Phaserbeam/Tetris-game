
//program execution starts from here
//The board is a 21 by 10 grid give or take
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Silk.NET.Core;
using Silk.NET.Input;
using Tetri;

Console.WriteLine("Press any button to begin:");

//Holds the data of the current Active Tetra as well as all dead Tetri
RestingPiece[] deadPieces = new RestingPiece[210];
for (int i = 0, x = 1, y = 0; i < 210; i++)
{
    deadPieces[i] = new RestingPiece();
    if (i % 10 == 0)
    {
        y++;
        x = 1;
    }
    deadPieces[i].y = y;
    deadPieces[i].x = x;
    x++;
}
Piece Active = new S();
Active.rotation = 3;
render(deadPieces, Active);

//Make sure to not close right away
Console.ReadLine();





/*
//Hitbox checker
int axis = 1;
int first;
if (3 - Active.rotation > 1)
{
    axis = 0;
}

for (int i = 0, x = 0; x < 4 || i < 16; i++)
{
    if (Active.hitboxes[axis, i] == Active.rotation || Active.hitboxes[axis, i] == 4)
    {
        first = i
        Console.WriteLine(i);
        x++;
    }
}
*/

static void render(RestingPiece[] Pieces, Piece Active)
{
    for (int i = 209; i > -1; --i)
    {


        //See wether to show the falling piece or nah
        //Distinguish what the rotation is    
        int axis = 1;
        if (3 - Active.rotation > 1)
        {
            axis = 0;
        }
        if (Pieces[i].x > Active.xOffset && Pieces[i].y > Active.yOffset && Pieces[i].x - Active.xOffset <= 4 && Pieces[i].y - Active.yOffset <= 4)
        {
            /* Rules for the function
            the difference between the x's can't be above 3 as well as y
            4(y-1) is added to the previous x to get the right part in the matrice
            Determining if it's in the square or nah
            -The difference between y and Pieces[i] y is not greater than 3 same as x
            -The offset is greater for the y, while the inverse is true for the xs
            In other words, make sure that
            1. they are inside the box
            2. calculate their position with (Pieces[i] - active) 3(active - Pieces[i])
            1
            */
            Console.ForegroundColor = ConsoleColor.Magenta;
            int value = 4* (Pieces[i].y-Active.yOffset-1) + Pieces[i].x-Active.xOffset -1;
            if (Active.Hitboxes[axis, value] == 4 || Active.Hitboxes[axis, value] == Active.rotation)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
        else
        {
            switch (Pieces[i].color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    break;
            }
        }
        Console.Write("[]");
        //Add a new line if i is divisible by 10
        if (i % 10 == 0)
        {
            Console.WriteLine("");
        }
    }
}
