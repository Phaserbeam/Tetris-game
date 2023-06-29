using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace Tetri
{
    public class RestingPiece
    {
        public string color = "green";
        public bool alive = false;
        public int y;
        public int x;
    }
    public abstract class Piece
    {
        //Defines which rotation for the variations of hitboxes
        public int rotation = 0;
        public int xOffset = 2;
        public int yOffset = 5;
        public virtual int[,] Hitboxes { get; set; }
    }
    public class I : Piece
    {

        public string color = "red";
        //Hitboxes to detect any collisions
        public override int[,] Hitboxes
        {
            get
            {
                return new int[,]
                {
                    {
                        -1, -1, 0, -1,
                        -1, -1, 0, -1,
                         1,  1, 4,  1,
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
        }
    };


    public class K : Piece
    {
        //Hitboxes to detect any collisions
        public override int[,] Hitboxes
        {
            get
            {
                return new int[,]
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
        }
    }
    public class Z : Piece
    {
        //Hitboxes to detect any collisions
        public override int[,] Hitboxes
        {
            get
            {
                return new int[,]
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
        }
    }


    public class S : Piece
    {
        //Hitboxes to detect any collisions
        public override int[,] Hitboxes
        {
            get
            {
                return new int[,]
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
        }
    }
    public class L : Piece
    {
        //Hitboxes to detect any collisions
        public override int[,] Hitboxes
        {
            get
            {
                return new int[,]
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
                    }
        };
            }
        }
    }
    public class J : Piece
    {
        //Hitboxes to detect any collisions
        public override int[,] Hitboxes
        {
            get
            {
                return new int[,]
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
                    }
                };
            }
        }

    }

    public class O : Piece
    {
        //Hitboxes to detect any collisions
        public override int[,] Hitboxes
        {
            get
            {
                return new int[,]
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
                    }
        };
            }
        }
    }
}