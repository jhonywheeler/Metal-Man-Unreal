using UnrealBuildTool;

public class MetalManProjectServerTarget : TargetRules
{
	public MetalManProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MetalManProject");
	}
}
