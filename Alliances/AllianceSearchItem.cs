
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Languages;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceSearchItem
	{
		// Fields
		[Json]
		// [Key]
		public long AllianceId;
		[Json]
		// [Key]
		public int SegmentId;
		[Json]
		// [Key]
		public Language Language;
		[Json]
		// [Key]
		public bool Deleted;
		[Json]
		// [Key]
		public int VacanciesCount;
		[Json]
		// [Key]
		public int AverageMemberLevel;
	
		// Constructors
		public AllianceSearchItem() {}
	}
}
