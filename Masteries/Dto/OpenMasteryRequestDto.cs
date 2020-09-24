
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Masteries.Dto
{
	[MessagePackObject]
	public class OpenMasteryRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int MasteryId;
		[Json]
		// [Key]
		public int HeroId;
	
		// Constructors
		public OpenMasteryRequestDto() {}
	}
}
