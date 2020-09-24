
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Gifts.Data
{
	[MessagePackObject]
	public class UiSettings
	{
		// Fields
		[Json]
		// [Key]
		public int TitleId;
		[Json]
		// [Key]
		public int DescriptionId;
		[Json]
		// [Key]
		public DateTimeCondition DowntimePeriod;
	
		// Constructors
		public UiSettings() {}
	}
}
