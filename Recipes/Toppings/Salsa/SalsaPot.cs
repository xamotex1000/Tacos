using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Salsa{
    public class SalsaPot : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Salsa Pot";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Pot);

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, TomatoPot>(),
                },
                Max = 1,
                Min = 1,
                IsMandatory = true,
            },
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(-1252408744),
                },
                IsMandatory = true,
                Max = 1,
                Min = 1,
            }
        };
        public override List<Item.ItemProcess> Processes => new()
        {
            new()
            {
                Result = GetCastedGDO<Item, DoneSalsa>(),
                Duration = 1f,
                Process = GetGDO<Process>(ProcessReferences.Chop)
            }
        };
        public override GameObject Prefab => GetPrefab("Salsa Pot");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Liquid", "Sink Water");
            prefab.ApplyMaterialToChild("Tomato/Skin", "Tomato");
            prefab.ApplyMaterialToChild("Tomato/Flesh", "Tomato Flesh");
            prefab.ApplyMaterialToChild("Tomato/Seeds", "Tomato Flesh 2");
            prefab.ApplyMaterialToChild("Onions/1", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Onions/2", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Onions/3", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Pot", "Metal");
            prefab.ApplyMaterialToChild("Pot/Handle", "Metal Dark");
        }
    }
}