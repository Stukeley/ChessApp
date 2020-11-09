namespace ChessApp.Code
{
	public class Field
	{
		public string Position { get; }

		public Field(int row, int column)
		{
			string p1 = (row + 1).ToString();
			string p2 = "";

			switch (column % 8)
			{
				case 0:
					p2 = "A";
					break;

				case 1:
					p2 = "B";
					break;

				case 2:
					p2 = "C";
					break;

				case 3:
					p2 = "D";
					break;

				case 4:
					p2 = "E";
					break;

				case 5:
					p2 = "F";
					break;

				case 6:
					p2 = "G";
					break;

				case 7:
					p2 = "H";
					break;
			}

			Position = p2 + p1;
		}
	}
}
