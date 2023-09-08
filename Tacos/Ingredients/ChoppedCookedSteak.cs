using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Ingredients{
    public class FinishedSteak : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Finished Steak";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override GameObject Prefab => GetPrefab("Steak");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Steak", "Well-done");
        }
    }
}