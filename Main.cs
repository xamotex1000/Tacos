using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenMods;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Mexican_Grill
{
    public class Main : BaseMod
    {
        // Mod Info 
        public const string GUID = "xamotex.MexicanFood";
        public const string NAME = "Mexican Grill";
        public const string VERSION = "1.0";
        public const string AUTHOR = "Milo Brown";
        public const string GAMEVERSION = ">=1.0.0";

        public Main() : base(GUID, NAME, AUTHOR, VERSION, GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        public static AssetBundle Bundle;

        protected override void OnPostActivate(Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).ToList()[0];
            AddGameData();
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
        public static T GetGDO<T>(int id) where T : GameDataObject => GDOUtils.GetExistingGDO(id) as T;
        public static GameObject GetPrefab(string name) => Bundle.LoadAsset<GameObject>(name);
        //you won't be needing this for the most part
        //public static T GetAsset<T>(string name) where T : UnityEngine.Object => Bundle.LoadAsset<T>(name);
    }
}