
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Normalization
{
	public interface INormalizable<TEditContext>
		where TEditContext : class, INormalizableContext
	{
		// Methods
		INEvent<TEditContext> GetNextEvent(TEditContext cx, DateTime time);
	}
}
