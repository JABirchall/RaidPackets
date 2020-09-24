
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class BossData : BossInfo
	{
		// Fields
		[Json]
		// [Key]
		public bool IsUnkillable;
	
		// Constructors
		public BossData() {}
	
		// Methods
		private new bool Equals(BossInfo other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}
}
