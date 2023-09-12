using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Salsa{
    public class Salsa : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Salsa";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Pot);
        public override GameObject Prefab => GetPrefab("Salsa Bowl");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Bowl", "Plate");
            prefab.ApplyMaterialToChild("Onions", "Onion - Flesh");
            prefab.ApplyMaterialToChild("Salsa", "Tomato Flesh");
        }
    }
}