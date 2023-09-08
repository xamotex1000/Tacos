using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tortilla{
    public class SoftShell : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Soft Shell";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;

        public override List<Item.ItemProcess> Processes => new()
        {
            new()
            {
                Result = GetCastedGDO<Item, HardShell>(),
                Duration = 1f,
                Process = GetGDO<Process>(ProcessReferences.Cook)
            },
            new()
            {
                Result = GetCastedGDO<Item, Tortilla>(),
                Duration = 1f,
                Process = GetGDO<Process>(ProcessReferences.Knead)
            }
        };

        public override GameObject Prefab => GetPrefab("Soft Taco Shell");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Soft Taco Shell", "Raw Pastry");
        }
    }
}