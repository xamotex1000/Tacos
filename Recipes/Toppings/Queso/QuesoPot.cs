using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Queso{
    public class QuesoPot : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Queso Pot";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Pot);

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, CheeseLettucePot>(),
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
                Result = GetCastedGDO<Item, DoneQueso>(),
                Duration = 1f,
                Process = GetGDO<Process>(ProcessReferences.Cook)
            }
        };
        public override GameObject Prefab => GetPrefab("Queso Pot");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Cheese", "Cheese");
            prefab.ApplyMaterialToChild("Lettuce", "Lettuce");
            prefab.ApplyMaterialToChild("Onions/1", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Onions/2", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Onions/3", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Pot", "Metal");
            prefab.ApplyMaterialToChild("Pot/Handle", "Metal Dark");
        }
    }
}
