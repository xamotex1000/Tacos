using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tacos{
    public class PlatedHardBeef : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "PlateHardBeef";
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
                    GDOUtils.GetCastedGDO<Item, HardBeef>()
                },
                Max = 2,
                Min = 2,
            }
        };
        public override GameObject Prefab => GetPrefab("Plated Hard Beef Taco");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Shell", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("Beef/Spill", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill1", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill2", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill3", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill4", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill5", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill6", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill7", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill8", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Plate", "Plate", "Plate - Ring");
        }
    }
}