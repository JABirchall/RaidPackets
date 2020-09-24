
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class AreaOpenCondition : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int UserLevelRequired;
	
		// Constructors
		public AreaOpenCondition() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(AreaOpenCondition other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
