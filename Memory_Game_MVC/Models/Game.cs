namespace Memory_Game_MVC.Models
{
    public class Game
    {
        public List<Tile> Tiles { get; set; }
        public Score Score { get; set; }
        public string GameState { get; set; }
    }
}
