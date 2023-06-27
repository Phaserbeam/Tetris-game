namespace Tetri
{
    public abstract class Piece
    {
        //Defines which rotation for the variations of hitboxes
        public int rotation = 0;
        //Fall rate
        int velocity = 0;
        //What the piece should be
    }
    public class I : Piece
    {
        //Hitboxes to detect any collisions
        public int[,] hitboxes =
        {
    {
            -1, -1, 0,-1,
            0, -1, 0, -1,
            1, 1, 4, 1,
            -1, -1, 0, -1
    },
        {
            0, 2, 0, 0,
            3, 4, 3, 3,
            0, 2, 0, 0,
            0, 2, 0, 0
        }
    };

    }
    public class K : Piece
    {
        //Hitboxes to detect any collisions
        public int[,] hitboxes =
        {
        {
            -1,-1,-1,-1,
            -1,-1, 4,-1,
            -1,0 , 4, 4,
            -1,-1, 1,-1,
        },

        {
            -1,-1,-1,-1,
            -1,-1,3,-1,
            -1,4,4,2,
            -1,-1,4,-1,
        }
    };

    }
    public class Z : Piece
    {
        //Hitboxes to detect any collisions
        public int[,] hitboxes =
        {
        {
            -1,-1,-1,0,
            -1,1,4,0,
            -1,-1,4,1,
            -1,-1,-1,-1
        },
        {
            -1,3,4,-1,
            -1,2,4,3,
            -1,2,-1,-1,
            -1,-1,-1,-1
        },
    };

    }
    public class S : Piece
    {
        //Hitboxes to detect any collisions
        public int[,] hitboxes =
        {
        {
            -1,0,1,1,
            -1,4,4,-1,
            -1,-1,0,-1,
            -1,-1,-1,-1
        },

        {
            -1,-1,2,-1,
            -1,-1,4,4,
            -1,3,3,2,
            -1,-1,-1,-1
        },
    };

    }
    public class L : Piece
    {
        //Hitboxes to detect any collisions
        public int[,] hitboxes =
        {
        {
            -1,-1,0,0,
            -1,1,4,1,
            -1,-1,0,1,
            -1,-1,-1,-1
        },
        {
            0,3,2,0,
            0,3,4,3,
            0,2,2,0,
            0,0,0,0,
        },
    };

    }
    public class J : Piece
    {
        //Hitboxes to detect any collisions
        public int[,] hitboxes =
        {
        {
            -1,1,0,-1,
            -1,1,4,1,
            -1,0,0,-1,
            -1,-1,-1,-1
        },

        {
            0,0,2,2,
            0,3,4,3,
            0,0,2,3,
            0,0,0,0,
        },
    };

    }

    public class O : Piece
    {
        //Hitboxes to detect any collisions
        public int[,] hitboxes =
        {
        {
            -1,-1,4,4,
            -1,-1,4,4,
            -1,-1,-1,-1,
            -1,-1,-1,-1,
        },

        {
            0,0,4,4,
            0,0,4,4,
            0,0,0,0,
            0,0,0,0,
        },
    };

    }
}