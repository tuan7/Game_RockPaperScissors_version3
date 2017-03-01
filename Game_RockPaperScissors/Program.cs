using System;

namespace Game_RockPaperScissors
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("Enter 1 if you play alone with computer or enter 2 if you have more than 2 players?");
			string paticipant_type = Console.ReadLine();
			int paticipantType = int.Parse(paticipant_type);
			StartGame startGameObj = new StartGame();
			startGameObj.SetPaticipantType(paticipantType);
			startGameObj.Start();

		}

	}
}


