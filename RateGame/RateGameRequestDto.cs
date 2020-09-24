
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.RateGame
{
	[MessagePackObject]
	public class RateGameRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int RatedValue;
	
		// Constructors
		public RateGameRequestDto() {}
	}
}
