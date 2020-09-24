
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Account
{
	public static class ResourcesExtensions
	{
		// Methods
		private static bool IsTypeEssence(ResourceTypeId resourceTypeId, int typeIndex) => default;
	
		// Extension methods
		public static bool IsNullOrEmpty(this Resources resources) => default;
		public static bool IsSoft(this ResourceTypeId resourceTypeId) => default;
		public static bool IsEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsArenaMedal(this ResourceTypeId resourceTypeId) => default;
		public static bool IsBronzeMedal(this ResourceTypeId resourceTypeId) => default;
		public static bool IsSilverMedal(this ResourceTypeId resourceTypeId) => default;
		public static bool IsGoldMedal(this ResourceTypeId resourceTypeId) => default;
		public static bool HasEnergy(this Resources resources) => default;
		public static bool HasTokens(this Resources resources) => default;
		public static bool IsMagicEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsForceEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsSpiritEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsVoidEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsArcaneEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsLowTypeEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsMediumTypeEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsHighTypeEssence(this ResourceTypeId resourceTypeId) => default;
		public static bool IsFactionWarsKey(this ResourceTypeId resourceTypeId) => default;
		public static bool IsForgeMaterial(this ResourceTypeId resourceTypeId) => default;
		public static bool IsRefillable(this ResourceTypeId resourceTypeId) => default;
		public static int ConvertMedalsTo(this ResourceTypeId fromResourceTypeId, int resources, ResourceTypeId toResourceTypeId) => default;
		public static bool CanConvertMedalsTo(this Resources resource, ResourceTypeId targetType) => default;
		public static ResourceKindId ToKindId(this ResourceTypeId typeId) => default;
		public static ResourceTypeId ToNextMedalGrade(this ResourceTypeId resourceTypeId) => default;
		public static Resources Sum(this IEnumerable<Resources> self) => default;
		public static bool HasForgeMaterials(this Resources resources) => default;
	}
}
