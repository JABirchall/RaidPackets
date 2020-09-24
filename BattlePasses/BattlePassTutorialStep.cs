
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.BattlePasses
{
	public enum BattlePassTutorialStep
	{
		IntroStarted = 1,
		IntroClosedByCross = 2,
		IntroClosedToWizard = 3,
		WizardStarted = 4,
		WizardEnded = 5
	}
}
