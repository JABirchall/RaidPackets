
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Quests
{
	public enum QuestFactoryId
	{
		GlobalEventBase = -1,
		Fluent = 10000,
		Feature = 60000,
		Periodic = 110000,
		Challenges = 160000,
		ChallengesV2 = 210000,
		Achievements = 260000,
		Recommended = 310000,
		GlobalEventSolo = 360000,
		NoviceTournament = 1360000,
		InfluencerTournament = 2360000,
		CommonTournament = 3360000,
		BattlePass = 4360000,
		AdvancedDaily = 5360000
	}
}
