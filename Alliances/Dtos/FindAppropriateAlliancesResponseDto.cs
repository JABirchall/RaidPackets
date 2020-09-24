
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.Notes;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class FindAppropriateAlliancesResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<AllianceSearchItem> AllianceSearchItems;
		[Json]
		// [Key]
		public List<AllianceNote> AllianceNotes;
		[Json]
		// [Key]
		public List<UserNote> UserNotes;
	
		// Constructors
		public FindAppropriateAlliancesResponseDto() {}
	}
}
