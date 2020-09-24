
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.GlobalMessages
{
	public enum ShowOnLoginMode
	{
		NotShow = 0,
		Show = 1,
		ShowIfNotRead = 2,
		ShowOnFirst = 3,
		ShowOnFirstIfNotRead = 4
	}
}
