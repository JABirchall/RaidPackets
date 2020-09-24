
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.UserPrizes
{
	public enum UserPrizeSource
	{
		Quest = 1,
		QuestAchievement = 2,
		QuestSpecial = 3,
		QuestChallenge = 4,
		QuestPeriodic = 5,
		QuestWizard = 6,
		QuestFeature = 7,
		QuestRecommended = 8,
		QuestGlobalEvent = 9,
		QuestTournament = 10,
		QuestAdvancedDaily = 11,
		BattleStory = 51,
		BattleDungeon = 52,
		BattleArena = 53,
		BattleAllianceBoss = 54,
		BattleFractions = 55,
		BattleArena3X3 = 56,
		LoyaltyProgram = 71,
		ReferralProgram = 72,
		DailyReward = 73,
		ArenaWeeklyReward = 81,
		MagicShop = 82,
		AmazonIntegration = 83,
		Arena3X3Shop = 84,
		Offer = 91,
		OfferCompensation = 92,
		StageStoryStars = 101,
		StageFractionWarStars = 102,
		StageFractionWarMainReward = 103,
		SessionChest = 111,
		AllianceActivityReward = 121,
		AllianceBossReward = 122,
		MilestoneLevelPrize = 141,
		UserLevelPrize = 142,
		LoadingBundles = 151,
		ModeratorSalary = 161,
		Compensation = 162,
		InboxOverflow = 163,
		ClientUpdate = 164,
		GooglePlayPoints = 165,
		Gift = 166,
		BattlePass = 167,
		BattlePassPayment = 168,
		Arena3X3League = 169,
		IdfaPopup = 170,
		GiftLinks = 171,
		Forge = 172
	}
}
