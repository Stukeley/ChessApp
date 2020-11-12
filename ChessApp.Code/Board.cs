namespace ChessApp.Code
{
	public static class Board
	{
		public static Field[,] Fields = new Field[8, 8];

		static Board()
		{
			for (int row = 0; row < 8; row++)
			{
				for (int col = 0; col < 8; col++)
				{
					Fields[row, col] = new Field(row, col);
				}
			}
		}
	}
}