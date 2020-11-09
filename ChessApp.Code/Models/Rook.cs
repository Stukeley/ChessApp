using System;
using System.Windows.Media.Imaging;

namespace ChessApp.Models
{
	internal class Rook : Piece
	{
		public Rook(Color color) : base(color)
		{
			Uri uri;

			if (Color == Color.Black)
			{
				uri = new Uri(@"/ChessApp;component/Assets/black_rook.png", UriKind.RelativeOrAbsolute);
			}
			else
			{
				uri = new Uri(@"/ChessApp;component/Assets/white_rook.png", UriKind.RelativeOrAbsolute);
			}

			PieceImage = new BitmapImage(uri);
		}
	}
}
