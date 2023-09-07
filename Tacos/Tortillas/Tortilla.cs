using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tortilla{
    public class Tortilla : CustomItem
    {
        public override string UniqueNameID => "Tortilla";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(ItemReferences.EggCracked),
                    GetGDO<Item>(ItemReferences.Dough)
                },
                Max = 2,
                Min = 2,
            }
        };

        public override GameObject Prefab => GetPrefab("Tortilla");
    }
}