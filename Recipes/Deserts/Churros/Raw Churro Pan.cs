using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Desserts.Churros{
    public class RawChurroPan : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Raw Churro";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override Item DisposesTo => GetCastedGDO<Item, ChurroPan>();
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, ChurroPan>(),
                },
                Max = 1,
                Min = 1,
                IsMandatory = true,
            },
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(1296980128),
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
                Result = GetCastedGDO<Item, CookedChurroPan>(),
                Duration = 5f,
                Process = GetGDO<Process>(ProcessReferences.Cook)
            }
        };
        public override GameObject Prefab => GetPrefab("Filled Churro Tray");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Tray", "Metal Very Dark");
            prefab.ApplyMaterialToChild("Inner", "Metal Very Dark");
            prefab.ApplyMaterialToChild("Churro 1", "Raw Pastry");
            prefab.ApplyMaterialToChild("Churro 2", "Raw Pastry");
        }
    }
}