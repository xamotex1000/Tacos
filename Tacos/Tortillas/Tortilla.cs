using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos.Tortilla
{
    public class Tortilla : CustomItemGroup //You're looking to make an itemgroup, not an item.
    {
        public override string UniqueNameID => "Tortilla";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
        {
            new ItemGroup.ItemSet()
            {
                Items = new List<Item>()
                {
                    Main.GetGDO<Item>(ItemReferences.EggCracked),
                    Main.GetGDO<Item>(ItemReferences.Dough)
                },
                Max = 2,
                Min = 2,
            }
        };

        public override GameObject Prefab => Main.GetPrefab("Tortilla");
    }
}