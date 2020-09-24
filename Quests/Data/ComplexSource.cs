
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Quests.Data
{
	public class ComplexSource
	{
		// Fields
		public long? Count;
		public long? Energy;
		public long? HeroLevelUps;
		public long? SkillLevelUps;
		public Quest Quest;
		public QuestState QuestState;
		public Account.Resources Resources;
		public List<Hero> Heroes;
		public List<Artifact> Artifacts;
		public Dictionary<BlackMarketItemId, int> BlackMarketItems;
		public long? PlariumId;
		public string FacebookId;
		public int? ChangeNameCount;
		public int? ChangeAvatarCount;
	
		// Constructors
		public ComplexSource() {}
		public ComplexSource(Quest quest, QuestState state) {}
	
		// Methods
		public static ComplexSource Create() => default;
		public ComplexSource SetCount(int count) => default;
		public ComplexSource SetEnergy(double energy) => default;
		public ComplexSource SetHeroLevelUps(int levelUps) => default;
		public ComplexSource SetSkillLevelUps(int levelUps) => default;
		public ComplexSource SetSummonedHeroes(List<Hero> summonedHeroes) => default;
		public ComplexSource SetAscendedHero(Hero ascendedHero) => default;
		public ComplexSource SetRankUpHero(Hero rankUpHero) => default;
		public ComplexSource SetBmi(Dictionary<BlackMarketItemId, int> items) => default;
		public ComplexSource SetResources(Account.Resources resources) => default;
		public ComplexSource SetArtifact(Artifact artifact) => default;
	}
}
