
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Ban
{
	public enum BanTypeId
	{
		Any = 0,
		Chat = 1,
		Account = 2,
		ChangeAccountName = 3,
		PrivateMessages = 4,
		LimitRequests = 5,
		Summon = 6
	}
}
