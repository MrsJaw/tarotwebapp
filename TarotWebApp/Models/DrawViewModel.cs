namespace TarotWebApp.Models
{
    public class DrawViewModel
    {
        public CardViewModel Card { get; set; }
        public int Index { get; set; }
        public string Role { get; set; }
        public bool IsReversed { get; set; }
    }
}
