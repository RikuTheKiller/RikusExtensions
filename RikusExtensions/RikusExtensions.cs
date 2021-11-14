using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using HarmonyLib;

namespace RikusExtensions
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class RikusExtensions : BaseUnityPlugin
    {
        private const string ModId = "com.RikuTheKiller.RikusExtensions";
        private const string ModName = "RikusExtensions";
        public const string Version = "1.0.0";
        public static RikusExtensions instance { get; private set; }

        void Awake()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
        }
    }
}