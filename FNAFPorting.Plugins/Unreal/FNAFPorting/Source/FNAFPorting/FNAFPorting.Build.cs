// Copyright Epic Games, Inc. All Rights Reserved.

namespace FNAFPorting.Plugins.Unreal.FNAFPorting.Source.FNAFPorting;

public class FNAFPorting : ModuleRules
{
	public FNAFPorting(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			[
				// ... add public include paths required here ...
			]
		);
		
		PrivateIncludePaths.AddRange(
			[
				// ... add other private include paths required here ...
			]
		);
		
		PublicDependencyModuleNames.AddRange(
			[
				"Core", "JsonUtilities", "Json", "PluginUtils", "UEFormat",
				"Projects", "UnrealEd", "EditorScriptingUtilities", "Sockets", "Networking",
				"InterchangeCore", "InterchangeEngine", "InterchangeImport", "InterchangeFactoryNodes", "InterchangePipelines"
				// ... add other public dependencies that you statically link with here ...
			]
		);
		
		PrivateDependencyModuleNames.AddRange(
			[
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore"
				// ... add private dependencies that you statically link with here ...	
			]
		);
		
		DynamicallyLoadedModuleNames.AddRange(
			[
				// ... add any modules that your module loads dynamically here ...
			]
		);
	}
}