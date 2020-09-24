
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Effects
{
	[MessagePackObject]
	public class UserEffectData
	{
		// Fields
		[Json]
		// [Key]
		public int LastEffectId;
		[Json]
		// [Key]
		public List<UserEffect> Effects;
	
		// Constructors
		public UserEffectData() {}
	}
}
