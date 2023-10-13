using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tacos{
    public class PlatedHardBeefGuac : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "PlateHardBeefGuac";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Plate);
        public override Item DirtiesTo => GetGDO<Item>(ItemReferences.PlateDirty);
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(793377380),
                    GDOUtils.GetCastedGDO<Item, HardBeefGuac>()
                },
                Max = 2,
                Min = 2,
            }
        };
        public override GameObject Prefab => GetPrefab("Plated Hard Beef Guac Taco");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Shell", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("Spill/Beef", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Beef1", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Beef2", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Beef3", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Beef4", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Salsa", "Avocado Inside", "Avocado Inside");
            prefab.ApplyMaterialToChild("Spill/Salsa1", "Meat Piece Cooked", "Avocado Inside");
            prefab.ApplyMaterialToChild("Spill/Salsa2", "Avocado Inside", "Avocado Inside");
            prefab.ApplyMaterialToChild("Spill/Salsa3", "Avocado Inside", "Avocado Inside");
            prefab.ApplyMaterialToChild("Spill/Salsa4", "Avocado Inside", "Avocado Inside");
            prefab.ApplyMaterialToChild("Spill/Salsa5", "Avocado Inside");
            prefab.ApplyMaterialToChild("Plate", "Plate", "Plate - Ring");
        }
    }
}
