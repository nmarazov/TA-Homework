namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
		public static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] gameField = CreateGameField();
			char[,] mines = PopulateGameField();
			int counter = 0;
			bool isDead = false;
			List<Player> ranking = new List<Player>(6);
			int row = 0;
			int col = 0;
			bool isInGame = true;
			const int Max = 35;
			bool isWin = false;

			do
			{
				if (isInGame)
				{
					Console.WriteLine(@"Lets play ""Minesweeper"". Try to find all mines and WIN." +
					" Command 'top' show ranking, 'restart' Start new game, 'exit' Leave current game!");
					DrawGameField(gameField);
					isInGame = false;
				}

				Console.Write("Input row and column : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out col) &&
						row <= gameField.GetLength(0) && 
                        col <= gameField.GetLength(1))
					{
						command = "turn";
					}
				}

				switch (command)
				{
					case "top":
						ShowRanking(ranking);
						break;
					case "restart":
						gameField = CreateGameField();
						mines = PopulateGameField();
						DrawGameField(gameField);
						isDead = false;
						isInGame = false;
						break;
					case "exit":
						Console.WriteLine("Bye, Bye, Bye!");
						break;
					case "turn":
						if (mines[row, col] != '*')
						{
							if (mines[row, col] == '-')
							{
								NextMove(gameField, mines, row, col);
								counter++;
							}

							if (Max == counter)
							{
								isWin = true;
							}
							else
							{
								DrawGameField(gameField);
							}
						}
						else
						{
							isDead = true;
						}

						break;
					default:
						Console.WriteLine("\nError! Invalid Command!\n");
						break;
				}

				if (isDead)
				{
					DrawGameField(mines);
					Console.Write("\nHrrrrrr! You died with {0} points. " + "Input your nickname: ", counter);
					string nickname = Console.ReadLine();
                    Player playerToAddInRanking = new Player(nickname, counter);
					if (ranking.Count < 5)
					{
						ranking.Add(playerToAddInRanking);
					}
					else
					{
						for (int i = 0; i < ranking.Count; i++)
						{
							if (ranking[i].Points < playerToAddInRanking.Points)
							{
								ranking.Insert(i, playerToAddInRanking);
								ranking.RemoveAt(ranking.Count - 1);
								break;
							}
						}
					}

					ranking.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
					ranking.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
					ShowRanking(ranking);

					gameField = CreateGameField();
					mines = PopulateGameField();
					counter = 0;
					isDead = false;
					isInGame = true;
				}

				if (isWin)
				{
					Console.WriteLine("\nGoodJob you find all mines without any blood.");
					DrawGameField(mines);
					Console.WriteLine("Input your nickname: ");
					string name = Console.ReadLine();
                    Player playerWithMaxPoints = new Player(name, counter);
					ranking.Add(playerWithMaxPoints);
					ShowRanking(ranking);
					gameField = CreateGameField();
					mines = PopulateGameField();
					counter = 0;
					isWin = false;
					isInGame = true;
				}
			}
			while (command != "exit");

			Console.WriteLine("Made in Bulgaria");
			Console.Read();
		}

		private static void ShowRanking(List<Player> ranking)
		{
			Console.WriteLine("\nPoints:");
			if (ranking.Count > 0)
			{
				for (int i = 0; i < ranking.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells", i + 1, ranking[i].Name, ranking[i].Points);
				}

				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty ranking!\n");
			}
		}

		private static void NextMove(char[,] gameField, char[,] mines, int row, int col)
		{
			char numberOfMinesNearCell = NumberOfMinesNearCell(mines, row, col);
			mines[row, col] = numberOfMinesNearCell;
			gameField[row, col] = numberOfMinesNearCell;
		}

		private static void DrawGameField(char[,] gameField)
		{
			int rows = gameField.GetLength(0);
			int cols = gameField.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);

				for (int j = 0; j < cols; j++)
				{
					Console.Write(string.Format("{0} ", gameField[i, j]));
				}

				Console.Write("|");
				Console.WriteLine();
			}

			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int fieldRows = 5;
			int fieldColumns = 10;
			char[,] gameField = new char[fieldRows, fieldColumns];
			for (int i = 0; i < fieldRows; i++)
			{
				for (int j = 0; j < fieldColumns; j++)
				{
					gameField[i, j] = '?';
				}
			}

			return gameField;
		}

		private static char[,] PopulateGameField()
		{
			int maxRowsInGameField = 5;
			int maxColsInGameField = 10;
		    int maxNumberOfMinesInGame = 15;

			char[,] gameField = new char[maxRowsInGameField, maxColsInGameField];

			for (int i = 0; i < maxRowsInGameField; i++)
			{
				for (int j = 0; j < maxColsInGameField; j++)
				{
					gameField[i, j] = '-';
				}
			}

			List<int> randomNumbersToCreateMines = new List<int>();
			while (randomNumbersToCreateMines.Count < maxNumberOfMinesInGame)
			{
				Random random = new Random();
				int tempRandomNumber = random.Next(50);
				if (!randomNumbersToCreateMines.Contains(tempRandomNumber))
				{
					randomNumbersToCreateMines.Add(tempRandomNumber);
				}
			}

			foreach (int number in randomNumbersToCreateMines)
			{
				int mineCol = number / maxColsInGameField;
				int mineRow = number % maxColsInGameField;
				if (mineRow == 0 && number != 0)
				{
					mineCol--;
					mineRow = maxColsInGameField;
				}
				else
				{
					mineRow++;
				}

				gameField[mineCol, mineRow - 1] = '*';
			}

			return gameField;
		}

		private static void GenerateNumberOfMinesNearEveryCell(char[,] gameField)
		{
			int fieldCols = gameField.GetLength(0);
			int fieldRows = gameField.GetLength(1);

			for (int i = 0; i < fieldCols; i++)
			{
				for (int j = 0; j < fieldRows; j++)
				{
					if (gameField[i, j] != '*')
					{
						char numberOfMinesNearCell = NumberOfMinesNearCell(gameField, i, j);
						gameField[i, j] = numberOfMinesNearCell;
					}
				}
			}
		}

		private static char NumberOfMinesNearCell(char[,] gameField, int column, int row)
		{
			int numberOfMinesNearCell = 0;
			int reds = gameField.GetLength(0);
			int kols = gameField.GetLength(1);

			if (column - 1 >= 0)
			{
				if (gameField[column - 1, row] == '*')
				{ 
					numberOfMinesNearCell++; 
				}
			}

			if (column + 1 < reds)
			{
				if (gameField[column + 1, row] == '*')
				{ 
					numberOfMinesNearCell++; 
				}
			}

			if (row - 1 >= 0)
			{
				if (gameField[column, row - 1] == '*')
				{ 
					numberOfMinesNearCell++;
				}
			}

			if (row + 1 < kols)
			{
				if (gameField[column, row + 1] == '*')
				{ 
					numberOfMinesNearCell++;
				}
			}

			if ((column - 1 >= 0) && (row - 1 >= 0))
			{
				if (gameField[column - 1, row - 1] == '*')
				{ 
					numberOfMinesNearCell++; 
				}
			}

			if ((column - 1 >= 0) && (row + 1 < kols))
			{
				if (gameField[column - 1, row + 1] == '*')
				{ 
					numberOfMinesNearCell++; 
				}
			}

			if ((column + 1 < reds) && (row - 1 >= 0))
			{
				if (gameField[column + 1, row - 1] == '*')
				{ 
					numberOfMinesNearCell++; 
				}
			}

			if ((column + 1 < reds) && (row + 1 < kols))
			{
				if (gameField[column + 1, row + 1] == '*')
				{ 
					numberOfMinesNearCell++; 
				}
			}

			return char.Parse(numberOfMinesNearCell.ToString());
		}
	}
}