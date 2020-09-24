
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class HeroLevelUpData
	{
		// Fields
		[Json]
		// [Key]
		public Element Element;
		[Json]
		// [Key]
		public int Xp;
		[Json]
		// [Key]
		public int XpOnCorrectElement;
		[Json]
		// [Key]
		public Account.Resources Price;
	
		// Constructors
		public HeroLevelUpData() {}
		public HeroLevelUpData(Element element, int xp, int xpOnCorrectElement, Account.Resources price) {}
	}
}
