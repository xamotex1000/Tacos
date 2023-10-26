using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Desserts.Churros{
    public class Churro : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Churro";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, CookedChurro>(),
                },
                Max = 1,
                Min = 1,
                IsMandatory = true,
            },
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, Cinnamon>(),
                    GetGDO<Item>(-849164789),
                },
                IsMandatory = true,
                Max = 2,
                Min = 2,
            },
        };
        public override GameObject Prefab => GetPrefab("Churro Done");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Base", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("Sugar/1", "Sugar");
            prefab.ApplyMaterialToChild("Sugar/2", "Sugar");
            prefab.ApplyMaterialToChild("Cinnamon/1", "Cinnamon (Instance)");
            prefab.ApplyMaterialToChild("Cinnamon/2", "Cinnamon (Instance)");
        }
    }
}