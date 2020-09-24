
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BattlePasses
{
	[MessagePackObject]
	public class BattlePassIntroPageData
	{
		// Fields
		[Json]
		// [Key]
		public string BackgroundUrl;
		[Json]
		// [Key]
		public string DescriptionKey;
	
		// Constructors
		public BattlePassIntroPageData() {}
	}
}
