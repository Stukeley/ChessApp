using ChessApp.Pieces;

namespace ChessApp.Code
{
	public class Field
	{
		public string Position { get; }
		public Piece Piece { get; private set; }

		public Field(int row, int column)
		{
			string p1 = (row + 1).ToString();
			string p2 = (column % 8 + 65).ToString();
			Position = p2 + p1;

			SetStartPiece();
		}

		private void SetStartPiece()
		{
			if (Position[1] == '2')
			{
				Piece = new Pawn(Color.White);
			}
			else if (Position[1] == '7')
			{
				Piece = new Pawn(Color.Black);
			}
			else if (Position[1] == '1')
			{
				switch (Position[0])
				{
					case 'A':
					case 'H':
						Piece = new Rook(Color.White);
						break;

					case 'B':
					case 'G':
						Piece = new Knight(Color.White);
						break;

					case 'C':
					case 'F':
						Piece = new Bishop(Color.White);
						break;

					case 'D':
						Piece = new Queen(Color.White);
						break;

					case 'E':
						Piece = new King(Color.White);
						break;
				}
			}
			else if (Position[1] == '6')
			{
				switch (Position[0])
				{
					case 'A':
					case 'H':
						Piece = new Rook(Color.Black);
						break;

					case 'B':
					case 'G':
						Piece = new Knight(Color.Black);
						break;

					case 'C':
					case 'F':
						Piece = new Bishop(Color.Black);
						break;

					case 'D':
						Piece = new Queen(Color.Black);
						break;

					case 'E':
						Piece = new King(Color.Black);
						break;
				}
			}
		}
	}
}