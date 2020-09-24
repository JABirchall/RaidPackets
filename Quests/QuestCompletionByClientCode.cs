
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Quests
{
	public enum QuestCompletionByClientCode
	{
		Skipped = -1,
		None = 0,
		TavernUnlocked = 1,
		ArenaUnlocked = 2,
		IntroFinished = 3,
		StorylinePrologueShown = 4,
		StorylineEpilogueShown = 5,
		TavernRankUpTabOpened = 6,
		TavernSkillLevelUpTabOpened = 7,
		TavernAwakeTabOpened = 8,
		ArenaBattleLogTabOpened = 9,
		ArenaTierListTabOpened = 10,
		FirstRegionCompleted = 11,
		ChampionsIndexResearched = 12,
		WizardExtraHeroesSummoned = 13,
		TurnOnNotifications = 14,
		RecommendedQuestsTabOpened = 15,
		ReferralLinkSent = 16,
		FractionWarsStageOpened = 17,
		BattlePassTabOpened = 18,
		ArenaHUDToArenaCompleted = 19,
		Arena3x3Opened = 20,
		ArenaHUDToArena3x3Completed = 21
	}
}
