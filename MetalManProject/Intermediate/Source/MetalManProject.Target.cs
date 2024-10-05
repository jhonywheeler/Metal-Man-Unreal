using UnrealBuildTool;

public class MetalManProjectTarget : TargetRules
{
	public MetalManProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MetalManProject");
	}
}
