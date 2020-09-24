
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.Stages;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena
{
	public interface IArenaSplitWeeklyReward
	{
		// Properties
		List<UserPrize> FixedPrizes { get; }
		FlexibleReward FlexibleReward { get; }
	}
}
