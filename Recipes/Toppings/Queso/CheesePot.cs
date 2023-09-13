using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Queso{
    public class CheesePot : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Cheese Pot";
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
                    GetGDO<Item>(-755280170),
                },
                IsMandatory = true,
                Max = 1,
                Min = 1,
            }
        };
        public override GameObject Prefab => GetPrefab("Cheese Pot");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Cheese", "Cheese - Default");
            prefab.ApplyMaterialToChild("Pot", "Metal");
            prefab.ApplyMaterialToChild("Pot/Handle", "Metal Dark");
        }
    }
}
