
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Notes;
using SharedModel.Meta.ReferralProgram.Data;



namespace SharedModel.Meta.ReferralProgram
{
	public static class ReferralProgramExtensions
	{
		// Extension methods
		public static bool IsValidSlotId(this UserReferralProgramData data, int slotId) => default;
		public static ReferralProgramSlot GetSlot(this UserReferralProgramData data, int slotId) => default;
		public static List<ReferralProgramSlot> GetFullSlots(this UserReferralProgramData data) => default;
		public static bool SlotIsEmpty(this UserReferralProgramData data, int slotId) => default;
		public static void AssertSlotIsValid(this UserReferralProgramData data, int slotId) {}
		public static void AssertSlotIsNotEmpty(this UserReferralProgramData data, int slotId) {}
		public static bool ReferralLevelIsAppropriateForReward(this ReferralProgramSlot slot, int level, UserNote userNote) => default;
		public static List<int> GetNotClaimedLevels(this ReferralProgramSlot slot) => default;
		public static bool RewardWasClaimedBefore(this ReferralProgramSlot slot, int level) => default;
		public static void AssertRewardWasNotClaimedBefore(this ReferralProgramSlot slot, int level) {}
		public static void AssertReferralLevelIsAppropriateForReward(this ReferralProgramSlot slot, int level, UserNote userNote) {}
		public static void AssertUserIsReferral(this UserReferralProgramData data) {}
		public static bool UserClaimedReferralReward(this UserReferralProgramData data) => default;
		public static bool UserClaimedFullSlotsReward(this UserReferralProgramData data) => default;
		public static bool UserCanClaimFullSlotsReward(this UserReferralProgramData data) => default;
		public static bool UserReferralSlotsContain(this UserReferralProgramData data, long referralId) => default;
		public static void AssertUserReferralSlotsDontContain(this UserReferralProgramData data, long referralId) {}
		public static void AssertUserNotClaimedReferralReward(this UserReferralProgramData data) {}
		public static void AssertUserNotClaimedFullSlotsReward(this UserReferralProgramData data) {}
		public static void AssertUserCanClaimFullSlotsReward(this UserReferralProgramData data) {}
		public static long RemoveReferredUser(this UserReferralProgramData data, int slotId) => default;
		public static IUndoState<long> RemoveReferredUserImpl(this UserReferralProgramData data, int slotId) => default;
		public static ReferralProgramSlot GetFirstEmptySlot(this UserReferralProgramData data) => default;
		public static int GetFullSlotsCount(this UserReferralProgramData data) => default;
	}
}
