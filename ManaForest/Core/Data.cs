using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaForest.Core
{
    public static class Data
    {
        public static int ScreenWidth { get; set; } = 1920;
        public static int ScreenHeight { get; set; } = 1080;
        public static bool Exit { get; set; } = false;

        public const int CANVAS_SIZE = 32;
        public enum Scenes
        {
            MainMenu,
            Game,
        }
        public static Scenes CurrentScene { get; set; } = Scenes.Game;
    }
}
