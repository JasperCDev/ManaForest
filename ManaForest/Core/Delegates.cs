using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaForest.Core
{
    internal static class Delegates
    {
        public delegate void HoeTiles(Rectangle selectorRect);
        public static HoeTiles hoeTiles;
    }
}
