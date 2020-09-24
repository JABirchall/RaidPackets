
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Account
{
	public enum ResourceTypeId
	{
		Energy = 1,
		Silver = 2,
		Token = 3,
		Gem = 4,
		Arena3X3ShopCurrency = 5,
		Arena3x3Token = 6,
		Orb_MagicLow = 101,
		Orb_MagicMid = 102,
		Orb_MagicHigh = 103,
		Orb_ForceLow = 111,
		Orb_ForceMid = 112,
		Orb_ForceHigh = 113,
		Orb_SpiritLow = 121,
		Orb_SpiritMid = 122,
		Orb_SpiritHigh = 123,
		Orb_VoidLow = 131,
		Orb_VoidMid = 132,
		Orb_VoidHigh = 133,
		Orb_ArcaneLow = 141,
		Orb_ArcaneMid = 142,
		Orb_ArcaneHigh = 143,
		Medal_Bronze = 201,
		Medal_Silver = 202,
		Medal_Gold = 203,
		AllianceBossKey = 300,
		AutoBattleTicket = 400,
		FractionWarKey_BannerLords = 501,
		FractionWarKey_HighElves = 502,
		FractionWarKey_SacredOrder = 503,
		FractionWarKey_CovenOfMagic = 504,
		FractionWarKey_OgrynTribes = 505,
		FractionWarKey_LizardMen = 506,
		FractionWarKey_Skinwalkers = 507,
		FractionWarKey_Orcs = 508,
		FractionWarKey_Demonspawn = 509,
		FractionWarKey_UndeadHordes = 510,
		FractionWarKey_DarkElves = 511,
		FractionWarKey_KnightsRevenant = 512,
		FractionWarKey_Barbarians = 513,
		FractionWarKey_NyresanElves = 514,
		FractionWarKey_Dwarves = 516,
		Forge_Magisteel = 601,
		Forge_Corehammer = 602,
		Forge_SoulstoneRare = 611,
		Forge_SoulstoneEpic = 612,
		Forge_SoulstoneLeg = 613,
		Forge_BloodstoneRare = 621,
		Forge_BloodstoneEpic = 622,
		Forge_BloodstoneLeg = 623
	}
}
