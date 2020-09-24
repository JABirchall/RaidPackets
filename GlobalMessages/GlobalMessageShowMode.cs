
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalMessages
{
	[MessagePackObject]
	public class GlobalMessageShowMode
	{
		// Fields
		[Json]
		// [Key]
		public GlobalMessageShowModeId Id;
		[Json]
		// [Key]
		public bool DisablePromoIfMessageExist;
		[Json]
		// [Key]
		public int MinLevel;
		[Json]
		// [Key]
		public int DaysAfterRegistration;
	
		// Constructors
		public GlobalMessageShowMode() {}
	}
}
