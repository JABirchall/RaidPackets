
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Normalization
{
	public interface INEvent
	{
		// Properties
		DateTime Time { get; }
	}
}
