using IngredientLib.Ingredient.Items;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Tacos.Tortilla;

namespace Mexican_Grill.Ingredients.Salsa
{
    public class SalsaRecipe : CustomDish
    {
        public override string UniqueNameID => "Salsa Recipe";
        public override GameObject DisplayPrefab => GetPrefab("Salsa Bowl");
        public override GameObject IconPrefab => GetPrefab("Salsa Bowl");
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsUnlockable => false;

        public override DishType Type => DishType.Base;

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Add A Tomato And Water To A Pot, Then Add An Onion. Chop And Serve. \n Serves 5" }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Salsa", "Salsa Recipe", "The party in your mouth where the chips are always invited!"))
        };

        public override void OnRegister(Dish gdo)
        {
            gdo.HideInfoPanel = true;
        }
    }
}