
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Masteries
{
	public static class MasteryExtensions
	{
		// Methods
		public static Dictionary<MasteryPointType, int> BuildMasteryPointsDictionary() => default;
		private static IUndoState SubtractMasteryPrice(Hero hero, MasteryType mastery) => default;
		public static bool CheckIsEnoughResorces(Hero hero, MasteryType mastery) => default;
		public static bool CheckMasteryTreeAvailability(List<MasteryType> openedMasteries, MasteryType mastery) => default;
		public static bool CheckMasteryParentsOpened(List<MasteryType> openedMasteries, MasteryType mastery) => default;
		public static bool CheckMasteryLineLimit(List<MasteryType> openedMasteries, MasteryType mastery) => default;
		public static bool CheckMasteryLineLimit(List<MasteryType> openedMasteries, MasteryTreeId treeId, int masteryRow) => default;
		public static bool CheckMasteryNeighboursOpened(List<MasteryType> openedMasteries, MasteryType mastery) => default;
	
		// Extension methods
		public static void AddMasteryPoints(this Hero hero, Dictionary<MasteryPointType, int> pointsByType, bool allPointsAdd = false) {}
		public static int TryAddMasteryPoints(this Hero hero, MasteryPointType masteryType, int count) => default;
		public static IUndoState<int> TryAddMasteryPointsImpl(this Hero hero, MasteryPointType masteryType, int count = 1) => default;
		public static void RemoveMasteryPoints(this Hero hero, MasteryPointType masteryType, int addedPoints) {}
		public static Hero BuildMasteryDataIfNeeded(this Hero hero) => default;
		public static void AssertOpenMastery(this Hero hero, int masteryId) {}
		public static IUndoState OpenMastery(this Hero hero, MasteryType mastery) => default;
		private static void AssertIsEnoughResorces(this Hero hero, MasteryType mastery) {}
		private static void AssertAlreadyOpenedMastery(this Hero hero, int masteryId) {}
		private static void AssertMasteryRank(this Hero hero, MasteryType mastery) {}
		private static void AssertMasteryTreeAvailability(this Hero hero, List<MasteryType> openedMasteries, MasteryType mastery) {}
		private static void AssertMasteryParentsOrNeighboursOpened(this Hero hero, List<MasteryType> openedMasteries, MasteryType mastery) {}
		private static void AssertMasteryLineLimit(this Hero hero, List<MasteryType> openedMasteries, MasteryType mastery) {}
		public static bool CheckMasteryRank(this Hero hero, MasteryType mastery) => default;
		public static bool CanOpenAnyMastery(this Hero hero) => default;
		public static bool CheckCanOpenMastery(this Hero hero, MasteryType masteryType) => default;
		public static void AssertResetMasteries(this Hero hero) {}
		public static IUndoState ResetMasteries(this Hero hero) => default;
		public static Dictionary<MasteryPointType, int> AssertBuyPoints(this Hero hero) => default;
	}
}
