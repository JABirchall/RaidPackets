
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Network
{
	public enum ResourceErrorHandlingPolicy
	{
		Silent = 0,
		PopupWithContinue = 1,
		PopupWithRelogin = 2
	}
}
