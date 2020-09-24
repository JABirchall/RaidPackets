
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Bundles
{
	public static class LoadingRewardsExtensions
	{
		// Extension methods
		public static UserAccount AssertRewardNotAlreadyCollected(this UserAccount data, List<int> indexes) => default;
		public static UserAccount AssertRewardsListNotEmpty(this UserAccount data, List<int> indexes) => default;
	}
}
