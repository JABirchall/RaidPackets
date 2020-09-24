
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Languages;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class FindAppropriateAlliancesDto
	{
		// Fields
		[Json]
		// [Key]
		public Language AllianceLanguage;
		[Json]
		// [Key]
		public int FromPosition;
	
		// Constructors
		public FindAppropriateAlliancesDto() {}
	}
}
