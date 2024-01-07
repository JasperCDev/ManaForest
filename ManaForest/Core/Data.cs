namespace ManaForest.Core
{
    public static class Data
    {
        public static readonly int ScreenWidth = 16 * 20 * 5;
        public static int ScreenHeight { get; set; } = 16 * 20 * 5;
        public static bool Exit { get; set; } = false;
        public static bool LoadingScene { get; set; }

        public const int CANVAS_SIZE = 16;
        public const int TARGET_WIDTH = 16 * 20;
        public const int TARGET_HEIGHT = 16 * 20;
        public enum Scenes
        {
            MainMenu,
            Game,
        }
        public static Scenes CurrentScene { get; set; } = Scenes.MainMenu;
    }
}
