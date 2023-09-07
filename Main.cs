global using static Mexican_Grill.Main;
global using static KitchenLib.Utils.GDOUtils;
global using static KitchenLib.Utils.LocalisationUtils;
using Kitchen;
using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Event;
using KitchenLib.Utils;
using KitchenMods;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using static KitchenLib.Utils.MaterialUtils;

namespace Mexican_Grill{
    public class Main : BaseMod
    {
        public const string GUID = "xamotex.MexicanFood";
        public const string VERSION = "1.0";

        public Main() : base(GUID, "Mexican Grill", "Milo Brown", VERSION, ">=1.0.0", Assembly.GetExecutingAssembly()) { }

        public static AssetBundle Bundle;

        protected override void OnPostActivate(Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).ToList()[0];
            AddGameData();
            Events.BuildGameDataEvent += (s, args) =>
            {
                args.gamedata.ProcessesView.Initialise(args.gamedata);
            };
        }
        internal void AddGameData()
        {
            MethodInfo AddGDOMethod = typeof(BaseMod).GetMethod(nameof(BaseMod.AddGameDataObject));
            int counter = 0;
            Log("Registering GameDataObjects.");
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsAbstract || typeof(IWontRegister).IsAssignableFrom(type))
                    continue;

                if (!typeof(CustomGameDataObject).IsAssignableFrom(type))
                    continue;

                MethodInfo generic = AddGDOMethod.MakeGenericMethod(type);
                generic.Invoke(this, null);
                counter++;
            }
            Log($"Registered {counter} GameDataObjects.");
        }
        public interface IWontRegister { }
        public static T GetGDO<T>(int id) where T : GameDataObject => GetExistingGDO(id) as T;
        public static GameObject GetPrefab(string name) => Bundle.LoadAsset<GameObject>(name);
        public static T GetAsset<T>(string name) where T : UnityEngine.Object => Bundle.LoadAsset<T>(name);
    }
}