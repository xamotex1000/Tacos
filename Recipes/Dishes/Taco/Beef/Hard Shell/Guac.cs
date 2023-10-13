using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tacos{
    public class HardBeefGuac : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "HardBeefGuac";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, MashedAvocado>(),
                    GDOUtils.GetCastedGDO<Item, HardBeef>()
                },
                Max = 2,
                Min = 2,
            }
        };
        public override GameObject Prefab => GetPrefab("Hard Beef Guac Taco");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Shell", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("Beef/1", "Avocado Inside");
            prefab.ApplyMaterialToChild("Beef/2", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/3", "Avocado Inside");
            prefab.ApplyMaterialToChild("Beef/4", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/5", "Avocado Inside");
            prefab.ApplyMaterialToChild("Beef/6", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/7", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/8", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/9", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/10", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/11", "Avocado Inside");
            prefab.ApplyMaterialToChild("Beef/12", "Meat Piece Cooked");
        }
    }
}