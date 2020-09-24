
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
	public class CreateAllianceDto
	{
		// Fields
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public string Abbreviation;
		[Json]
		// [Key]
		public Language Language;
	
		// Constructors
		public CreateAllianceDto() {}
	}
}
