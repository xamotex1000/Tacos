// I come back to the code and dont know what anything means. How do i write this and then completely forget what it means?!?!
global using static Mexican_Grill.Main;
global using static KitchenLib.Utils.GDOUtils;
global using static KitchenLib.Utils.LocalisationUtils;
using static KitchenLib.Utils.MaterialUtils;
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

namespace Mexican_Grill
{
    public class Main : BaseMod
    {
        internal static T Find<T>(int id) where T : GameDataObject
        {
            return (T)GDOUtils.GetExistingGDO(id) ?? (T)GDOUtils.GetCustomGameDataObject(id)?.GameDataObject;
        }

        public const string GUID = "xamotex.MexicanFood";
        public const string VERSION = "1.0";
        public static AssetBundle Bundle;

        public Main() : base(GUID, "Mexican Grill", "xamotex1000", VERSION, ">=1.0.0", Assembly.GetExecutingAssembly()) { }

        private void PreBuild()
        {
            // Reserved
        }
        protected override void OnPostActivate(Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault();
            PreBuild();
            AddGameData();
        }

        internal void AddGameData()
        {
            MethodInfo addGDOMethod = typeof(BaseMod).GetMethod(nameof(BaseMod.AddGameDataObject));
            int counter = 0;
            Log("Registering GameDataObjects.");
            
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsAbstract || typeof(IWontRegister).IsAssignableFrom(type) || !typeof(CustomGameDataObject).IsAssignableFrom(type))
                    continue;

                MethodInfo generic = addGDOMethod.MakeGenericMethod(type);
                generic.Invoke(this, null);
                counter++;
            }
            
            Log($"Registered {counter} GameDataObjects.");
        }

        public interface IWontRegister { }

        public static T GetGDO<T>(int id) where T : GameDataObject => GetExistingGDO(id) as T;
        public static GameObject GetPrefab(string name) => Bundle?.LoadAsset<GameObject>(name);
        public static T GetAsset<T>(string name) where T : UnityEngine.Object => Bundle?.LoadAsset<T>(name);
    }
}