using UnrealBuildTool;

public class MetalManProjectClientTarget : TargetRules
{
	public MetalManProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MetalManProject");
	}
}
