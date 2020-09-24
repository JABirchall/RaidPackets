
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Masteries
{
	[MessagePackObject]
	public class MasteryRewardInfo : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public MasteryPointType Type;
		[Json]
		// [Key]
		public int MinCount;
		[Json]
		// [Key]
		public int MaxCount;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool IsEmpty { get => default; }
	
		// Constructors
		public MasteryRewardInfo() {}
		public MasteryRewardInfo(MasteryPointType type, int minCount, int maxCount) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(MasteryRewardInfo other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
