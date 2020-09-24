
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.Arena.Dtos
{
	[MessagePackObject]
	public class SetArenaDefenseRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int[] HeroIds;
	
		// Constructors
		public SetArenaDefenseRequestDto() {}
	}
}
