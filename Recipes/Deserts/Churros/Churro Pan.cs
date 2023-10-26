using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Desserts.Churros{
    public class ChurroPan : CustomItemGroup<ItemGroupView>
    {
        public override Appliance DedicatedProvider => GetCastedGDO<Appliance, ChurroPanProv>();
        public override string UniqueNameID => "Churro Pan";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetCastedGDO<Item, ChurroPan>();
        public override GameObject Prefab => GetPrefab("Empty Churro Tray");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Tray", "Metal Very Dark");
            prefab.ApplyMaterialToChild("Inner", "Metal Very Dark");
        }
    }
}