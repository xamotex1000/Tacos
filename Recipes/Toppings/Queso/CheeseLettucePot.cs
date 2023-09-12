using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Queso{
    public class CheeseLettucePot : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Cheese Lettuce Pot";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Pot);

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, CheesePot>(),
                },
                Max = 1,
                Min = 1,
                IsMandatory = true,
            },
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(000),
                },
                IsMandatory = true,
                Max = 1,
                Min = 1,
            }
        };
        public override GameObject Prefab => GetPrefab("CL Pot");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Cheese", "Cheese");
            prefab.ApplyMaterialToChild("Lettuce", "Lettuce");
            prefab.ApplyMaterialToChild("Pot", "Metal");
            prefab.ApplyMaterialToChild("Pot/Handle", "Metal Dark");
        }
    }
}
