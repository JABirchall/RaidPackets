
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.PeriodicQuests.Data
{
	public enum PeriodicQuestPrototypeId
	{
		SummonHero = 110000,
		AscendHero = 110001,
		SkillUpHero = 110002,
		LevelUpHero = 110003,
		RankUpHero = 110004,
		SummonThreeStarHero = 110005,
		AscendHeroToSpecificGrade = 110006,
		FightInArenaBattles = 110100,
		WinArenaBattles = 110101,
		ClearScenario = 110102,
		DefeatStoryBoss = 110103,
		DefeatDungeonBoss = 110104,
		PurchaseItemInMagicShop = 110200,
		CollectFreeShard = 110201,
		UseEnergy = 110202,
		UpgradeArtifacts = 110203,
		UpgradeArtifactsToSpecificLevel = 110204,
		PerformPack = 110300,
		CompleteQuests = 110301
	}
}
