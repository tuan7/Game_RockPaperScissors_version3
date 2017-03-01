using System;
namespace Game_RockPaperScissors
{
	public class StartGame
	{
		int participantType;

		public void SetPaticipantType(int participan_type)
		{
			this.participantType = participan_type;
		}

		public void Start()
		{
			Participant participantObj = new Participant();
			int a = 0;
			int b = 0;
			switch (this.participantType)
			{
				
				case 1:
					Console.WriteLine("Enter your name");
					string participant_a = Console.ReadLine();
					participantObj.SetUserA(participant_a);
					participantObj.SetUserB("Computer");
					for (int i = 1; i < 10; i++)//it will be 10 games
					{
						Console.WriteLine(participantObj.GetUserA() + ": Enter 1 for paper, 2 for rock, 3 for scissors");

						string user_A_Input = participantObj.ReadPassword(); //get user A input (hidden text by using def. ReadPassword instead "Console.ReadLine()")
						a = int.Parse(user_A_Input);

						Random rnd = new Random();
						b = rnd.Next(1, 4); //random number generater by computer
						participantObj.SetUserA_val(a);
						participantObj.SetUserB_val(b);
						participantObj.Participate();
					}
					break;
				case 2:
					Console.WriteLine("How many players?");
					string num_of_players = Console.ReadLine();
					int num_of_players_int = int.Parse(num_of_players);
					participantObj.SetNumOfPlayers(num_of_players_int);
					int[] players = new int[participantObj.numOfPlayers];
					int rounds = 0;
					for (int i = 1; i < players.Length; i++) //Count number of rounds
					{
						rounds = rounds + (players.Length - i);
					}
					Console.WriteLine("You have : " + rounds + " rounds each other");
					for (int j = 1; j <= rounds; j++)
					{
						Console.WriteLine("Rounds: " + j);

						Console.WriteLine("Enter player's name 1");
						string participantA = Console.ReadLine();
						participantObj.SetUserA(participantA);
						Console.WriteLine(participantObj.GetUserA() + ": Enter 1 for paper, 2 for rock, 3 for scissors");
						string user_A_Input = participantObj.ReadPassword(); //get user B input (hidden text by using def. ReadPassword instead "Console.ReadLine()")
						a = int.Parse(user_A_Input);

						Console.WriteLine("Enter player's name 2");
						string participantB = Console.ReadLine();
						participantObj.SetUserB(participantB);
						Console.WriteLine(participantObj.GetUserB() + ": Enter 1 for paper, 2 for rock, 3 for scissors");
						string user_B_Input = participantObj.ReadPassword(); //get user B input (hidden text by using def. ReadPassword instead "Console.ReadLine()")
						b = int.Parse(user_B_Input);

						participantObj.SetUserA_val(a);
						participantObj.SetUserB_val(b);
						participantObj.Participate();
					}

					break;
			}

			Console.WriteLine("Game over!");
		}
	}
}
