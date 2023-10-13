using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Ingredients.Salsa;

namespace Mexican_Grill.Tacos.Tacos{
    public class PlatedSoftBeefSalsa : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "PlateSoftBeefSalsa";
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
                    GDOUtils.GetCastedGDO<Item, SoftBeefSalsa>()
                },
                Max = 2,
                Min = 2,
            }
        };
        public override GameObject Prefab => GetPrefab("Plated Soft Beef Salsa Taco");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Shell", "Raw Pastry");
            prefab.ApplyMaterialToChild("Spill/Beef", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Beef1", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Beef2", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Beef3", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Beef4", "Meat Piece Cooked", "Meat Piece Cooked");
            prefab.ApplyMaterialToChild("Spill/Salsa", "Tomato", "Tomato");
            prefab.ApplyMaterialToChild("Spill/Salsa1", "Meat Piece Cooked", "Tomato Flesh");
            prefab.ApplyMaterialToChild("Spill/Salsa2", "Tomato", "Tomato Flesh");
            prefab.ApplyMaterialToChild("Spill/Salsa3", "Tomato", "Onion - Flesh");
            prefab.ApplyMaterialToChild("Spill/Salsa4", "Tomato", "Tomato Flesh");
            prefab.ApplyMaterialToChild("Spill/Salsa5", "Tomato");
            prefab.ApplyMaterialToChild("Plate", "Plate", "Plate - Ring");
        }
    }
}
