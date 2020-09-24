
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Quests
{
	public enum QuestCompletionByActionCode
	{
		Skipped = -1,
		None = 0,
		BuyItemInMarket = 1,
		SelectFirstHero = 2,
		FailToUpgradeArtifact = 3,
		FuseSmallPotion = 4,
		FuseMediumPotion = 5,
		ExpandSlotsInTheMarket = 6,
		BuyArtifactsInTheMarket = 7,
		BuyShardsInTheMarket = 8,
		GetXpInTrainingCamp = 9,
		CollectSilverFromLocationDrop = 10,
		ChangeUserName = 11,
		ChangeUserAvatar = 12,
		ConnectToPlariumId = 13,
		ConnectToFacebook = 14,
		UserSignIn = 15,
		UseAnyLevelUpBlackMarketItem = 16,
		JoinAllianceOrSendRequest = 17,
		UpgradeCapitolBonus = 18,
		GatherAllSessionChests = 19,
		SellArtifact = 20,
		SellAccessory = 21,
		FuseAnyPotion = 22,
		UseAnyPowerUpItem = 23,
		UseAnyForgeBooster = 24,
		SellArtifactOrAccessory = 25,
		OpenHeroMastery = 26,
		UpgradeAccessory = 27
	}
}
