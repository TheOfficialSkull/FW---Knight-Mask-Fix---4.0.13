using SPTarkov.Server.Core.Models.Spt.Mod;
using SemanticVersioning;

namespace FWKnightMaskFix;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "https://forge.sp-tarkov.com/user/111932/flex-wayne#mods";
    public override string Name { get; init; } = "Flex Wayne's Knight Mask Fix";
    public override string Author { get; init; } = "Flex Wayne (modernized version of Umbigo Preto's Face the Knight Mask Fix)";
    public override List<string>? Contributors { get; init; }
    public override SemanticVersioning.Version Version { get; init; } = new("1.0.0");
    public override SemanticVersioning.Range SptVersion { get; init; } = new("4.0.13");
    public override List<string>? Incompatibilities { get; init; }
    public override Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; }
    public override string? Url { get; init; } = "https://github.com/TheOfficialSkull/SPT---Knight-Mask-Fix---4.0.13/blob/main/README.md?plain=1";
    public override bool? IsBundleMod { get; init; } = true;
    public override string License { get; init; } = "MIT";
}