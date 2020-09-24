
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Battle.Arena3x3
{
	public enum Arena3x3TutorialStep
	{
		None = 0,
		FeatureUnlockViewClicked = 1,
		FeatureUnlockCloseClicked = 2,
		ArenaMap = 3,
		BattleTab = 4,
		ShopTransition = 5,
		ShopTab = 6,
		WizardEnded = 7
	}
}
