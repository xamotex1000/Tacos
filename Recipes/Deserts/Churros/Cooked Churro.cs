using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Desserts.Churros{
    public class CookedChurro : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Cooked Churro";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override GameObject Prefab => GetPrefab("Churro Base");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterial("Pie - Mushroom");
        }
    }
}