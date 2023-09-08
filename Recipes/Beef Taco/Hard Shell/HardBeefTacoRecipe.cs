using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tacos
{
    public class HardBeefRecipe : CustomDish
    {
        public override string UniqueNameID => "Hard Beef Recipe";
        public override GameObject DisplayPrefab => GetPrefab("Plated Hard Beef Taco");
        public override GameObject IconPrefab => GetPrefab("Hard Beef Taco");
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsUnlockable => false;

        public override DishType Type => DishType.Base;

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Knead Flour Or Add Water To Make Dough, Add Egg To Make A Tortilla, Interact To Shape Into A Shell, Cook To Harden The Shell, Add Chopped Steak, Cook, Plate, Serve" }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Hard Shell Beef Taco", "Hard Beef Taco Recipe", "Like trying to fold a fitted sheet, but tastier!"))
        };

        public override void OnRegister(Dish gdo)
        {
            gdo.HideInfoPanel = true;
        }
    }
}