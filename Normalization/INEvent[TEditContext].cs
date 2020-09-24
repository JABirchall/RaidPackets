
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Normalization
{
	public interface INEvent<TEditContext> : INEvent
		where TEditContext : class, INormalizableContext
	{
		// Methods
		void Process(TEditContext context, DateTime fromTime);
	}
}
