
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BlackMarket;



namespace SharedModel.Meta.ReferralProgram.Data
{
	[MessagePackObject]
	public class ReferralProgramSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public int FeatureUnlockLevelRequired;
		[Json]
		// [Key]
		public BlackMarketItemId[] BlackMarketItemsToInbox;
	
		// Constructors
		public ReferralProgramSettings() {}
	}
}
