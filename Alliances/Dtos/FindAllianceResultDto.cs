
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class FindAllianceResultDto
	{
		// Fields
		[Json]
		// [Key]
		public List<AllianceNote> AllianceNotes;
	
		// Constructors
		public FindAllianceResultDto() {}
	}
}
