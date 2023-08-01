using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManaForest
{
    public enum SpaceType
    {
        Empty,
        Occupied
    }
    public class BoardSpace
    {
        public SpaceType type;
        public string id;

        public BoardSpace(string spaceId, SpaceType spaceType) 
        {
            type = spaceType;
            id = spaceId;
        }

        public void OnBoardSpaceClick()
        {
            this.type = this.type == SpaceType.Empty ? SpaceType.Occupied : SpaceType.Empty;
        }
    }
    public class Board
    {
        public BoardSpace[,] grid = new BoardSpace[3, 3];
        public Board() { 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var id = i.ToString() + j.ToString();
                    grid[i, j] = new BoardSpace(id, SpaceType.Empty);
                }
            }
        }
    }
}
