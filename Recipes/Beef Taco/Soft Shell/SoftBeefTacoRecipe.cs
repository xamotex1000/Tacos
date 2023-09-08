using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tacos
{
    public class SoftBeefRecipe : CustomDish
    {
        public override string UniqueNameID => "Soft Beef Recipe";
        public override GameObject DisplayPrefab => GetPrefab("Plated Soft Beef Taco");
        public override GameObject IconPrefab => GetPrefab("Soft Beef Taco");
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsUnlockable => false;

        public override DishType Type => DishType.Base;

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Knead Flour Or Add Water To Make Dough, Add Egg To Make A Tortilla, Interact To Shape Into A Shell, Add Chopped Steak, Cook, Plate, Serve" }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Soft Shell Beef Taco", "Soft Beef Taco Recipe", "Who needs a hard life when you can have a soft taco?"))
        };

        public override void OnRegister(Dish gdo)
        {
            gdo.HideInfoPanel = true;
        }
    }
}