
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BattlePasses.Dtos
{
	[MessagePackObject]
	public class BattlePassRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public long KnownHash;
	
		// Constructors
		public BattlePassRequestDto() {}
	}
}
