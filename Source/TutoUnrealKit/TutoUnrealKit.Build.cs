// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TutoUnrealKit : ModuleRules
{
	public TutoUnrealKit(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TutoUnrealKit",
			"TutoUnrealKit/Variant_Platforming",
			"TutoUnrealKit/Variant_Platforming/Animation",
			"TutoUnrealKit/Variant_Combat",
			"TutoUnrealKit/Variant_Combat/AI",
			"TutoUnrealKit/Variant_Combat/Animation",
			"TutoUnrealKit/Variant_Combat/Gameplay",
			"TutoUnrealKit/Variant_Combat/Interfaces",
			"TutoUnrealKit/Variant_Combat/UI",
			"TutoUnrealKit/Variant_SideScrolling",
			"TutoUnrealKit/Variant_SideScrolling/AI",
			"TutoUnrealKit/Variant_SideScrolling/Gameplay",
			"TutoUnrealKit/Variant_SideScrolling/Interfaces",
			"TutoUnrealKit/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
