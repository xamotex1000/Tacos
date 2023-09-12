using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tortilla{
    public class Tortilla : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Tortilla";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GetGDO<Item>(ItemReferences.EggCracked),
                    GetGDO<Item>(ItemReferences.Dough)
                },
                Max = 2,
                Min = 2,
            }
        };
        public override List<Item.ItemProcess> Processes => new()
        {
            new()
            {
                Result = GetCastedGDO<Item, SoftShell>(),
                Duration = 1f,
                Process = GetGDO<Process>(ProcessReferences.Knead)
            },
            new()
            {
                Result = GetCastedGDO<Item, CookedTortilla>(),
                Duration = 1.5f,
                Process = GetGDO<Process>(ProcessReferences.Cook)
            }
        };

        public override GameObject Prefab => GetPrefab("Tortilla");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Tortilla", "Raw Pastry");
        }
    }
}