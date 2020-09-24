
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Effects
{
	[MessagePackObject]
	public class UserEffect
	{
		// Fields
		[Json]
		// [Key]
		public long Id;
		[Json]
		// [Key]
		public UserEffectTypeId TypeId;
		[Json]
		// [Key]
		public UserEffectSource Source;
		[Json]
		// [Key]
		public double Power;
		[Json]
		// [Key]
		public DateTime Start;
		[Json]
		// [Key]
		public DateTime Finish;
	
		// Constructors
		public UserEffect() {}
	}
}
