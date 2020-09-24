
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances.Boss;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class CreateAllianceBossBattleRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public AllianceBossTypeId Id;
		[Json]
		// [Key]
		public int[] HeroIds;
	
		// Constructors
		public CreateAllianceBossBattleRequestDto() {}
	}
}
