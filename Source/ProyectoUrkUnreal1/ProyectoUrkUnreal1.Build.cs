// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProyectoUrkUnreal1 : ModuleRules
{
	public ProyectoUrkUnreal1(ReadOnlyTargetRules Target) : base(Target)
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
			"ProyectoUrkUnreal1",
			"ProyectoUrkUnreal1/Variant_Platforming",
			"ProyectoUrkUnreal1/Variant_Platforming/Animation",
			"ProyectoUrkUnreal1/Variant_Combat",
			"ProyectoUrkUnreal1/Variant_Combat/AI",
			"ProyectoUrkUnreal1/Variant_Combat/Animation",
			"ProyectoUrkUnreal1/Variant_Combat/Gameplay",
			"ProyectoUrkUnreal1/Variant_Combat/Interfaces",
			"ProyectoUrkUnreal1/Variant_Combat/UI",
			"ProyectoUrkUnreal1/Variant_SideScrolling",
			"ProyectoUrkUnreal1/Variant_SideScrolling/AI",
			"ProyectoUrkUnreal1/Variant_SideScrolling/Gameplay",
			"ProyectoUrkUnreal1/Variant_SideScrolling/Interfaces",
			"ProyectoUrkUnreal1/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
