
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.PerformanceMeter
{
	public enum StatisticsType
	{
		FramesPerSecond = 0,
		RenderTime = 1,
		UpdateTime = 2,
		ContextRefreshTime = 3
	}
}
