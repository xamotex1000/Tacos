using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using Mexican_Grill.Ingredients.Salsa;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tacos{
    public class SoftBeefSalsa : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "SoftBeefSalsa";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, Salsa>(),
                    GDOUtils.GetCastedGDO<Item, SoftBeef>()
                },
                Max = 2,
                Min = 2,
            }
        };
        public override GameObject Prefab => GetPrefab("Soft Beef Salsa Taco");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Shell", "Raw Pastry");
            prefab.ApplyMaterialToChild("Beef/1", "Tomato");
            prefab.ApplyMaterialToChild("Beef/2", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/3", "Tomato");
            prefab.ApplyMaterialToChild("Beef/4", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/5", "Tomato");
            prefab.ApplyMaterialToChild("Beef/6", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/7", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/8", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/9", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/10", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Beef/11", "Tomato");
            prefab.ApplyMaterialToChild("Beef/12", "Meat Piece Cooked");
        }
    }
}