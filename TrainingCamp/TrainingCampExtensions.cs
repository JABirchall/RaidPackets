
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.TrainingCamp
{
	public static class TrainingCampExtensions
	{
		// Extension methods
		public static TrainingCampSlotInfo GetTrainingCampSlot(this UserTrainingCampData data, int slotIndex) => default;
		public static UserTrainingCampData AssertSlotsCountLimitReached(this UserTrainingCampData data) => default;
		public static Account.Resources GetNextSlotPrice(this UserTrainingCampData data) => default;
		public static TrainingCampSlotInfo AddSlot(this UserTrainingCampData data) => default;
		public static IUndoState LevelUp(this TrainingCampSlotInfo slot) => default;
		public static bool HasHero(this TrainingCampSlotInfo slot) => default;
		public static IUndoState RemoveHero(this TrainingCampSlotInfo slot) => default;
		public static TrainingCampSlotInfo ResetTrainingStartTime(this TrainingCampSlotInfo slot) => default;
		public static TrainingCampSlotInfo UpdateTrainingStartTime(this TrainingCampSlotInfo slot) => default;
		public static DateTime GetTrainingEndTime(this Hero hero, TrainingCampSlotInfo slotInfo) => default;
		public static UserTrainingCampData AssertIsSlotExist(this UserTrainingCampData heroData, int slotIndex) => default;
		public static UserTrainingCampData AssertSlotsInitializedIs(this UserTrainingCampData heroData, bool isTrue) => default;
		public static TrainingCampSlotInfo AssertHeroInSlotIs(this TrainingCampSlotInfo slot, bool isTrue) => default;
		public static TrainingCampSlotInfo AssertStartTimeSetIs(this TrainingCampSlotInfo slot, bool isTrue) => default;
		public static TrainingCampSlotInfo AssertSlotMaxLevelIs(this TrainingCampSlotInfo slot, bool isTrue) => default;
		public static TrainingCampSlotInfo GetHeroSlot(this UserTrainingCampData data, int heroId) => default;
		public static UserTrainingCampData AssertHeroNotInTrainingCamp(this UserTrainingCampData data, int heroId) => default;
	}
}
