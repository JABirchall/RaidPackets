
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plarium.Common.Numerics;



namespace SharedModel.Meta.Heroes
{
	public static class ElementExtension
	{
		// Extension methods
		public static bool IsVoid(this Element element) => default;
		public static bool IsSpirit(this Element element) => default;
		public static bool IsForce(this Element element) => default;
		public static bool IsMagic(this Element element) => default;
		public static bool IsElementAdvantageOver(this Element currentElement, Element otherElement) => default;
		public static ElementRelation GetElementRelation(this Element currentElement, Element otherElement) => default;
		public static int CompareToElement(this Element element1, Element element2) => default;
		public static int GetCompareToValue(this Element element) => default;
		public static Fixed GetDamagePercent(this ElementRelation relation) => default;
	}
}
