using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Tacos.Tortilla;

namespace Mexican_Grill.Tacos.Tacos{
    public class HardBeefRaw : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "HardBeefRaw";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(1005005768),
                    GDOUtils.GetCastedGDO<Item, HardShell>()
                },
                Max = 2,
                Min = 2,
            }
        };
        public override List<Item.ItemProcess> Processes => new()
        {
            new()
            {
                Result = GetCastedGDO<Item, HardBeef>(),
                Duration = 1f,
                Process = GetGDO<Process>(ProcessReferences.Cook)
            }
        };
        public override GameObject Prefab => GetPrefab("Raw Hard Beef Taco");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Shell", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("Beef/1", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/2", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/3", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/4", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/5", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/6", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/7", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/8", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/9", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/10", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/11", "Meat Piece Raw");
            prefab.ApplyMaterialToChild("Beef/12", "Meat Piece Raw");
        }
    }
}