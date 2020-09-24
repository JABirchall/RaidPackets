
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BattlePasses
{
	[MessagePackObject]
	public class BattlePassIntroData
	{
		// Fields
		[Json]
		// [Key]
		public string LogoUrl;
		[Json]
		// [Key]
		public string CoverBackgroundUrl;
		[Json]
		// [Key]
		public string CoverTitleKey;
		[Json]
		// [Key]
		public string CoverDescriptionKey;
		[Json]
		// [Key]
		public List<BattlePassIntroPageData> Pages;
	
		// Constructors
		public BattlePassIntroData() {}
	}
}
