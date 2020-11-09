using System;
using System.Windows.Media.Imaging;

namespace ChessApp.Models
{
	internal class Knight : Piece
	{
		public Knight(Color color) : base(color)
		{
			Uri uri;

			if (Color == Color.Black)
			{
				uri = new Uri(@"/ChessApp;component/Assets/black_knight.png", UriKind.RelativeOrAbsolute);
			}
			else
			{
				uri = new Uri(@"/ChessApp;component/Assets/white_knight.png", UriKind.RelativeOrAbsolute);
			}

			PieceImage = new BitmapImage(uri);
		}
	}
}
