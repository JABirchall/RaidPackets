
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Masteries
{
	[MessagePackObject]
	public class MasterySettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public bool ResetMasteriesEnabled;
		[Json]
		// [Key]
		public bool BuyPointsEnabled;
		[Json]
		// [Key]
		public bool ResetEnabled;
		[Json]
		// [Key]
		public double ResetPriceInGems;
		[Json]
		// [Key]
		public double BuyPointsPriceInGems;
		[IgnoreMember]
		[JsonSkip]
		private Account.Resources _resetPrice;
		[IgnoreMember]
		[JsonSkip]
		private Account.Resources _buyPointsPrice;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Account.Resources ResetPrice { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Account.Resources BuyPointsPrice { get => default; }
	
		// Constructors
		public MasterySettings() {}
	
		// Methods
		public MasterySettings Clone() => default;
	}
}
