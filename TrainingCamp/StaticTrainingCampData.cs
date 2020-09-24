
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.TrainingCamp
{
	[MessagePackObject]
	public class StaticTrainingCampData
	{
		// Fields
		[Json]
		// [Key]
		public List<List<Account.Resources>> LevelPriceBySlot;
		[Json]
		// [Key]
		public Dictionary<int, Dictionary<HeroGrade, int>> XpByHeroGradeBySlotLevel;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int MaxSlotsCount { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int MaxSlotLevel { get => default; }
	
		// Constructors
		public StaticTrainingCampData() {}
	}
}
