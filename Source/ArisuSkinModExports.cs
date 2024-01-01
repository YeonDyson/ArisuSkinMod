using MonoMod.ModInterop;

namespace Celeste.Mod.ArisuSkinMod {
    /// <summary>
    /// Provides export functions for other mods to import.
    /// If you do not need to export any functions, delete this class and the corresponding call
    /// to ModInterop() in <see cref="ArisuSkinModModule.Load"/>
    /// </summary>
    [ModExportName("ArisuSkinMod")]
    public static class ArisuSkinModExports {
        // TODO: add your mod's exports, if required
    }
}
