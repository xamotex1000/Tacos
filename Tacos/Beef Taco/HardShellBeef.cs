using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tacos{
    public class HardBeef : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "HardBeef";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(716846967),
                    GetGDO<Item>(716846967)
                },
                Max = 2,
                Min = 2,
            }
        };

        public override GameObject Prefab => GetPrefab("Hard Beef Taco");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Hard Beef Taco/Shell", "Raw Pastry");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/1", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/2", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/3", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/4", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/5", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/6", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/7", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/8", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/9", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/10", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/11", "Button Blocked");
            prefab.ApplyMaterialToChild("Hard Beef Taco/Beef/12", "Button Blocked");
        }
    }
}