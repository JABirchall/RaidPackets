
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
	public class UpdateAllianceSettingsDto
	{
		// Fields
		[Json]
		// [Key]
		public string MessageOfTheDay;
		[Json]
		// [Key]
		public string Description;
		[Json]
		// [Key]
		public int? RequiredMemberLevel;
		[Json]
		// [Key]
		public Language? Language;
		[Json]
		// [Key]
		public bool? IsOpen;
	
		// Constructors
		public UpdateAllianceSettingsDto() {}
	}
}
