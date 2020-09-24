
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Offers.Enums
{
	public enum CooldownPurchaseType
	{
		Unlimited = 1,
		CooldownHours_12 = 2,
		CooldownDay_1 = 10,
		CooldownWeek_1 = 20,
		CooldownMonth_1 = 30
	}
}
