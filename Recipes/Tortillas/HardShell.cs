using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tortilla{
    public class HardShell : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Hard Shell";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override GameObject Prefab => GetPrefab("Hard Taco Shell");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Hard Taco Shell", "Raw Pastry");
        }
    }
}