
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.RateGame
{
	[MessagePackObject]
	public class RateGameSettings
	{
		// Fields
		[Json]
		// [Key]
		public int MinAllowableRate;
		[Json]
		// [Key]
		public int ShowRateUsDelayMinutes;
		[Json]
		// [Key]
		public bool IsEnabled;
		[IgnoreMember]
		[JsonSkip]
		private TimeSpan? _showDelay;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public TimeSpan ShowDelay { get => default; }
	
		// Constructors
		public RateGameSettings() {}
	}
}
