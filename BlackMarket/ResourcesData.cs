
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class ResourcesData
	{
		// Fields
		[Json]
		// [Key]
		public bool MaxEnergy;
		[Json]
		// [Key]
		public bool MaxTokens;
		[Json]
		// [Key]
		public bool MaxArena3X3Tokens;
	
		// Constructors
		public ResourcesData() {}
	}
}
