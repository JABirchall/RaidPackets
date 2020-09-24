
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class StageStartCondition : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public Account.Resources Price;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Account.Resources AutoBattlePrice { get; private set; }
	
		// Constructors
		public StageStartCondition() {}
	
		// Methods
		public Account.Resources GetPrice(bool isAutoBattle = false) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
