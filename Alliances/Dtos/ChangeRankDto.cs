
using System;
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
	public class ChangeRankDto
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public AllianceMemberRankId RankId;
	
		// Constructors
		public ChangeRankDto() {}
	}
}
