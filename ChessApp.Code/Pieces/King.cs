namespace ChessApp.Pieces
{
	internal class King : Piece
	{
		public King(Color color) : base(color)
		{
			Uri uri;

			if (Color == Color.Black)
			{
				uri = new Uri(@"/ChessApp;component/Assets/black_king.png", UriKind.RelativeOrAbsolute);
			}
			else
			{
				uri = new Uri(@"/ChessApp;component/Assets/white_king.png", UriKind.RelativeOrAbsolute);
			}

			PieceImage = new BitmapImage(uri);
		}
	}
}
