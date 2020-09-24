
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Notifications.Enums
{
	public enum NotificationTypeId
	{
		TestNotification = -1,
		ArenaBattle = 1,
		AllianceBossRewardIssued = 2,
		AllianceChestReceived = 3,
		UserAcceptedIntoAlliance = 4,
		AllianceBossHealthLessThanThird = 5,
		ReferralSlotFilledOut = 6,
		NewUserInAlliance = 7,
		UserLeftAlliance = 8,
		GlobalEventStarted = 11,
		GlobalEventExpiring = 12,
		LoyaltyReward = 101,
		EnergyRecovered = 102,
		TokenRecovered = 103,
		OrbDungeonActivated = 104,
		HeroLevelUp = 105,
		MaxGemMine = 106,
		EnergyOverload = 107,
		EndWeeklyRaiting = 108,
		Virality = 109,
		GrantPermissions = 110,
		AllianceBossKeysRecovered = 111,
		AllDungeonsOpened = 112,
		DailyLoyaltyRewardAvailable = 113,
		StrongHeroes = 114,
		MonthlyLoyaltyRewardAvailable = 115,
		ShardAvailable = 116,
		HistoryIsWaiting = 117,
		FreeAncientShardAvailable = 118,
		BattlePassQuestsAvailable = 119,
		XPBoosterWillEndSoon = 120,
		DungeonTrip = 121,
		ArenaHike = 122,
		BattleCampaign = 123,
		NotificationTool = 305
	}
}
