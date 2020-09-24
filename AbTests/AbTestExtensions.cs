
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.AbTests
{
	public static class AbTestExtensions
	{
		// Extension methods
		public static bool HasAbTest(this UserAbTestData userData, AbTestTypeId typeId) => default;
		public static AbTest GetAbTest(this UserAbTestData userData, AbTestTypeId typeId) => default;
		public static bool IsGroupA(this UserAbTestData userData, AbTestTypeId typeId) => default;
		public static bool IsGroupB(this UserAbTestData userData, AbTestTypeId typeId) => default;
		public static bool IsGroupC(this UserAbTestData userData, AbTestTypeId typeId) => default;
		public static bool IsGroupD(this UserAbTestData userData, AbTestTypeId typeId) => default;
		public static bool IsInGroup(this UserAbTestData userData, AbTestGroupId groupId, AbTestTypeId typeId) => default;
		public static Dictionary<AbTestTypeId, AbTestType> GetActiveTests(this StaticAbTestData staticData, DateTime time) => default;
		public static bool IsTestActive(this StaticAbTestData staticData, AbTestTypeId typeId, DateTime time) => default;
		public static bool IsTestActive(this AbTestType test, DateTime time) => default;
		public static void AssertClaimIdfaTestReward(this UserAbTestData testData, UserAccount account) {}
	}
}
