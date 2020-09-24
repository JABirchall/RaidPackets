
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Heroes
{
	public enum ReadyStatus
	{
		Unknown = 0,
		Balance = 10,
		Rebalance = 15,
		Preview3D = 20,
		SkillsSetup = 30,
		PreChecked = 35,
		Checked = 40,
		Quarantine = 50
	}
}
