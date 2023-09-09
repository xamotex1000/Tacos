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
            prefab.ApplyMaterialToChild("Beef/1", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/2", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/3", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/4", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/5", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/6", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/7", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/8", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/9", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/10", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/11", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/12", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Plate", "Plate", "Plate - Rim");
        }
    }
}