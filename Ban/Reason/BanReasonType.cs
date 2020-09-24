
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Ban.Reason
{
	public enum BanReasonType
	{
		InvalidBattles = 1,
		MultipleAccounts = 2,
		TooManyRefunds = 3,
		Spam = 4,
		PlayersRequest = 5,
		Obscene = 6,
		Insult = 7,
		Other = 100
	}
}
