
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalRatings
{
	[MessagePackObject]
	public class SignInGlobalRatingData
	{
		// Fields
		[Json]
		// [Key]
		public GlobalRatingSettings Settings;
		[Json]
		// [Key]
		public bool Enabled;
	
		// Constructors
		public SignInGlobalRatingData() {}
	}
}
