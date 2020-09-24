
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceAppearanceData
	{
		// Fields
		[Json]
		// [Key]
		public string Abbreviation;
		[Json]
		// [Key]
		public string Description;
		[Json]
		// [Key]
		public string Logo;
		[Json]
		// [Key]
		public string MessageOfTheDay;
	
		// Constructors
		public AllianceAppearanceData() {}
	}
}
