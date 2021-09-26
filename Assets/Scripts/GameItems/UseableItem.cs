using UnityEngine;
using System.Collections;

//Note: I am going to base some of my automated testing off of catching the error of:
//"Nothing" being a valid random selection between Rock, Paper, or Scissors,
//by the enemy player. 

//I am also concluding that it is a bug, due to that the Enemy player has a 50%
//chance of pulling a draw, as their random number selection goes from 0-4.

//I can see a possible design where a "none" option is included in the game's
//design in the future. For instance, if the player wanted to "stay" or "fold",
//like in blackjack or poker, but such action would not be a selection of any of
//the three. For now though, I'll make it so that the enemy choice of "none" is 
//caught by the automated testing as an error.

public enum UseableItem
{
	None,
	Rock,
	Paper,
	Scissors
}