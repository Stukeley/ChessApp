using System.Windows;
using System.Windows.Media.Imaging;

namespace ChessApp.Models
{
	public enum Color
	{
		Black, White
	}
	public class Piece
	{
		public BitmapImage PieceImage { get; set; }

		public Point? CurrentPosition = null;

		public Color Color;

		public Piece(Color color)
		{
			// Upewniamy się, że kolor jest ustawiony od razu, aby uniknać problemów z klasami pochodnymi
			Color = color;
		}
	}
}
