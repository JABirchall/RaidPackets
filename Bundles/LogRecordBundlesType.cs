
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Bundles
{
	public enum LogRecordBundlesType
	{
		StartBundles_1 = 1,
		FinishBundles_1 = 2,
		StartBundles_2 = 11,
		FinishBundles_2 = 12,
		StartAll = 20,
		FinishAll = 21,
		StartInitial = 22,
		FinishInitial = 23,
		StartInitialAfterWizard = 24,
		FinishInitialAfterWizard = 25,
		StartOnDemand = 26,
		FinishOnDemand = 27,
		StartInitialAfterWizardUpdate = 28,
		FinishInitialAfterWizardUpdate = 29,
		StartUpdate = 30,
		FinishUpdate = 31,
		StartOnDemandUpdate = 32,
		FinishOnDemandUpdate = 33,
		StartInitialUpdate = 34,
		FinishInitialUpdate = 35
	}
}
