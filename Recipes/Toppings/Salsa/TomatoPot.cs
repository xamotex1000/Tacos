using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Salsa{
    public class TomatoPot : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Tomato Pot";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Pot);

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(-486398094),
                },
                Max = 1,
                Min = 1,
                IsMandatory = true,
            },
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(1657174953),
                },
                IsMandatory = true,
                Max = 1,
                Min = 1,
            },
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(-853757044),
                },
                IsMandatory = true,
                Max = 1,
                Min = 1,
            }
        };
        public override GameObject Prefab => GetPrefab("Tomato Pot");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Liquid", "Sink Water");
            prefab.ApplyMaterialToChild("Tomato/Skin", "Tomato");
            prefab.ApplyMaterialToChild("Tomato/Flesh", "Tomato Flesh");
            prefab.ApplyMaterialToChild("Tomato/Seeds", "Tomato Flesh 2");
            prefab.ApplyMaterialToChild("Pot", "Metal");
            prefab.ApplyMaterialToChild("Pot/Handle", "Metal Dark");
        }
    }
}