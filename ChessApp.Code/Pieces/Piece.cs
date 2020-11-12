namespace ChessApp.Pieces
{
	public enum Color
	{
		Black, White
	}

	public abstract class Piece
	{
		public BitmapImage PieceImage { get; set; }

		public int X { get; }
		public int Y { get; }

		public Color Color;

		public Piece(Color color)
		{
			// Upewniamy się, że kolor jest ustawiony od razu, aby uniknać problemów z klasami pochodnymi
			Color = color;
		}

		// Sprawdzamy, czy dana figura moze poruszyc sie w dane miejsce zgodnie z regulami
		public abstract bool CanMove(int newX, int newY);
	}
}