using MelonLoader;
using BTD_Mod_Helper;
using CamsPaths;
using Il2CppAssets.Scripts.Models.Towers;
using PathsPlusPlus;

[assembly: MelonInfo(typeof(CamsPaths.CamsPaths), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CamsPaths;

public class CamsPaths : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<CamsPaths>("Cam's Paths loaded!");
    }
}

public class BananaGunPath : PathPlusPlus
{
    public override string Tower => TowerType.BananaFarm;
    public override int UpgradeCount => 5;
}

public class SabrePath : PathPlusPlus
{
    public override string Tower => TowerType.BananaFarm;
    public override int UpgradeCount => 5;
}