using System;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.ArisuSkinMod {
    public class ArisuSkinModModule : EverestModule {
        public static ArisuSkinModModule Instance { get; private set; }

        public override Type SettingsType => typeof(ArisuSkinModModuleSettings);
        public static ArisuSkinModModuleSettings Settings => (ArisuSkinModModuleSettings) Instance._Settings;

        public override Type SessionType => typeof(ArisuSkinModModuleSession);
        public static ArisuSkinModModuleSession Session => (ArisuSkinModModuleSession) Instance._Session;

        public override Type SaveDataType => typeof(ArisuSkinModModuleSaveData);
        public static ArisuSkinModModuleSaveData SaveData => (ArisuSkinModModuleSaveData) Instance._SaveData;

        public ArisuSkinModModule() {
            Instance = this;
#if DEBUG
            // debug builds use verbose logging
            Logger.SetLogLevel(nameof(ArisuSkinModModule), LogLevel.Verbose);
#else
            // release builds use info logging to reduce spam in log files
            Logger.SetLogLevel(nameof(ArisuSkinModModule), LogLevel.Info);
#endif
        }

        public override void Load() {
            // TODO: apply any hooks that should always be active
        }

        public override void Unload() {
            // TODO: unapply any hooks applied in Load()
        }
    }
}
