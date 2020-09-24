
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Notes
{
	public interface INote
	{
		// Properties
		long Id { get; set; }
		bool Outdated { get; set; }
	}
}
