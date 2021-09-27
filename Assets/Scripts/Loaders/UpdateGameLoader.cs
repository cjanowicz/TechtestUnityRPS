using UnityEngine;
using System.Collections;
using System;


/// <summary>
///I am going to base some of my automated testing off of catching the error of:
///"Nothing" being a valid random selection between Rock, Paper, or Scissors,
///by the enemy player, in the load() function.
///
///I am also concluding that it is a bug, due to that the Enemy player has a 50%
///chance of pulling a draw, as their random number selection goes from 0-4.
///
///I can see a possible design where a "none" option is included in the game's
///design in the future. For instance, if the player wanted to "stay" or "fold",
///like in blackjack or poker, or if "Quit game" was an action.
///Such action would not be a selection of any of the three. 
///For now though, I'll make it so that the enemy choice of "none" is 
///caught by the automated testing as an error.
/// </summary>


public class UpdateGameLoader
{
	public delegate void OnLoadedAction(Hashtable gameUpdateData);
	public event OnLoadedAction OnLoaded;

	private UseableItem _choice;

	public UpdateGameLoader(UseableItem playerChoice)
	{
		_choice = playerChoice;
	}


	public void load()
	{
		UseableItem opponentHand = (UseableItem)Enum.GetValues(typeof(UseableItem)).GetValue(UnityEngine.Random.Range(0, 4));

		Hashtable mockGameUpdate = new Hashtable();
		mockGameUpdate["resultPlayer"] = _choice;
		mockGameUpdate["resultOpponent"] = opponentHand;
		mockGameUpdate["coinsAmountChange"] = GetCoinsAmount(_choice, opponentHand);
		
		OnLoaded(mockGameUpdate);
	}

	private int GetCoinsAmount (UseableItem playerHand, UseableItem opponentHand)
	{
		Result drawResult = ResultAnalyzer.GetResultState(playerHand, opponentHand);

		if (drawResult.Equals (Result.Won))
		{
			return 10;
		}
		else if (drawResult.Equals (Result.Lost))
		{
			return -10;
		}
		else
		{
			return 0;
		}

		return 0;
	}
}