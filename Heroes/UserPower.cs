
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Village;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class UserPower
	{
		// Fields
		[Json]
		// [Key]
		public int Total;
		[Json]
		// [Key]
		public int Heroes;
		[Json]
		// [Key]
		public int Artifacts;
		[Json]
		// [Key]
		public int Arena;
		[Json]
		// [Key]
		public int Masteries;
		[Json]
		// [Key]
		public int Capitol;
		[Json]
		// [Key]
		public int HeroesCount;
	
		// Constructors
		public UserPower() {}
		public UserPower(long userId, UserAccount account, UserHeroData heroData, UserArtifactData artifactData, UserVillageData villageData, UserArenaData arenaData) {}
	}
}
