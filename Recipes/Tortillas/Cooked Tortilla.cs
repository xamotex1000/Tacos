using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Starters.TortillaChips;

namespace Mexican_Grill.Tacos.Tortilla{
    public class CookedTortilla : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Cooked Tortilla";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override List<Item.ItemProcess> Processes => new()
        {
            new()
            {
                Result = GetCastedGDO<Item, TortillaChips>(),
                Duration = 2f,
                Process = GetGDO<Process>(ProcessReferences.Chop)
            }
        };
        public override GameObject Prefab => GetPrefab("Cooked Tortilla");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Tortilla", "Pie - Mushroom");
        }
    }
}