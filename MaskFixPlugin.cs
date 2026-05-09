using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Spt.Mod;
using SPTarkov.Server.Core.Models.Utils;
using SPTarkov.Server.Core.Services;

namespace FaceTheKnightMaskFix;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class MaskFixPlugin(
    ISptLogger<MaskFixPlugin> logger,
    DatabaseService databaseService)
    : IOnLoad
{
    private const string KnightMaskId = "62963c18dbc8ab5f0d382d0b";

    public Task OnLoad()
    {
        FixKnightMask();
        logger.Success("[Face the Knight - Mask Fix] Loaded successfully!");
        return Task.CompletedTask;
    }

    private void FixKnightMask()
    {
        var items = databaseService.GetItems();

        if (items.TryGetValue(KnightMaskId, out var mask) && mask?.Properties?.Prefab != null)
        {
            mask.Properties.Prefab.Path = "maskfix.bundle";
            mask.Properties.Prefab.Rcid = "";

            logger.Success($"[Face the Knight] Successfully repointed {KnightMaskId} to maskfix.bundle");
        }
        else
        {
            logger.Error("[Face the Knight] Could not find Knight mask or Prefab object in database!");
        }
    }
}