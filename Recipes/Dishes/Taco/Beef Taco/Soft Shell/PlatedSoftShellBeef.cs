using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tacos{
    public class PlatedSoftBeef : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "PlateSoftBeef";
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
                    GDOUtils.GetCastedGDO<Item, SoftBeef>()
                },
                Max = 2,
                Min = 2,
            }
        };
        public override GameObject Prefab => GetPrefab("Plated Soft Beef Taco");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Shell", "Raw Pastry");
            prefab.ApplyMaterialToChild("Beef/Spill", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill1", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill2", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill3", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/Spill4", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Plate", "Plate", "Plate - Ring");
        }
    }
}