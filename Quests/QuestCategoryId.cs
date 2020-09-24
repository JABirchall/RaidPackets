
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Quests
{
	public enum QuestCategoryId
	{
		None = 0,
		Feature = 1,
		Wizard = 2,
		Periodic = 3,
		Challenge = 4,
		Special = 5,
		Achievement = 6,
		Recommended = 7,
		GlobalEventSolo = 11,
		NoviceTournament = 12,
		InfluencerTournament = 13,
		CommonTournament = 14,
		BattlePass = 15,
		AdvancedDaily = 16
	}
}
