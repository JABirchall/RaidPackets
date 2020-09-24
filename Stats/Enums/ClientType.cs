
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Stats.Enums
{
	[Flags]
	public enum ClientType
	{
		Unknown = 0,
		Web = 1,
		Mobile = 2,
		WebGL = 4,
		Desktop = 5
	}
}
