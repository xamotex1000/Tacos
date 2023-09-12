using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Starters.TortillaChips{
    public class TortillaChips : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Tortilla Chips";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Pot);
        public override GameObject Prefab => GetPrefab("Tortilla Chips");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("1", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("2", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("3", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("4", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("5", "Pie - Mushroom");
        }
    }
}