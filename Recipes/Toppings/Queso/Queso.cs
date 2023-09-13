using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Queso{
    public class Queso : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Queso";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override GameObject Prefab => GetPrefab("Salsa Bowl");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Bowl", "Plate");
            prefab.ApplyMaterialToChild("Onions", "Lettuce");
            prefab.ApplyMaterialToChild("Salsa", "Cheese - Default");
        }
    }
}
