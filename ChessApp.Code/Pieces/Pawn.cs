using System;

namespace ChessApp.Pieces
{
	public class Pawn : Piece
	{
		public bool FirstMove => false;

		public Pawn(Color color) : base(color)
		{
			Uri uri;

			if (Color == Color.Black)
			{
				uri = new Uri(@"/ChessApp;component/Assets/black_pawn.png", UriKind.RelativeOrAbsolute);
			}
			else
			{
				uri = new Uri(@"/ChessApp;component/Assets/white_pawn.png", UriKind.RelativeOrAbsolute);
			}

			PieceImage = new BitmapImage(uri);
		}
	}
}