
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.BattlePasses
{
	[MessagePackObject]
	public class BattlePassLevel : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int Points;
		[Json]
		// [Key]
		public UserPrize FreeReward;
		[Json]
		// [Key]
		public UserPrize EliteReward;
	
		// Constructors
		public BattlePassLevel() {}
	
		// Methods
		public int CalcHash() => default;
	}
}
