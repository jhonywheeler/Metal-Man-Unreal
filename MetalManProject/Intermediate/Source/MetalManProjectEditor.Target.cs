using UnrealBuildTool;

public class MetalManProjectEditorTarget : TargetRules
{
	public MetalManProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MetalManProject");
	}
}
