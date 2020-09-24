
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Effects;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class UserEffectInfo : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public UserEffectTypeId TypeId;
		[Json]
		// [Key]
		public UserEffectSource Source;
		[Json]
		// [Key]
		public DateTime? ExpirationTime;
		[Json]
		// [Key]
		public TimeSpan? Duration;
		[Json]
		// [Key]
		public double Power;
		[Json]
		// [Key]
		public bool Stacked;
	
		// Constructors
		public UserEffectInfo() {}
	
		// Methods
		public UserEffectInfo Clone() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(UserEffectInfo other) => default;
		private bool EqualsExpirationTime(UserEffectInfo other) => default;
		private bool EqualsEffectDuration(UserEffectInfo other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
		public string ToStringShort() => default;
	}
}
