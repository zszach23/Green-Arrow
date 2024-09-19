// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GreenArrow : ModuleRules
{
	public GreenArrow(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
