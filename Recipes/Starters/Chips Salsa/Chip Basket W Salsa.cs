using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Appliances.BasketProvider;
using Mexican_Grill.Ingredients.Salsa;

namespace Mexican_Grill.Starters.TortillaChips{
    public class ChipBasketSalsa : CustomItemGroup<ItemGroupView>
    {
        public override Appliance DedicatedProvider => GetCastedGDO<Appliance, BasketStack>();
        public override string UniqueNameID => "Salsa Chip Basket";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override Item DirtiesTo => GetCastedGDO<Item, Basket>();
        public override Item DisposesTo => GetCastedGDO<Item, Basket>();
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new()
            {
                Items = new()
                {
                    GDOUtils.GetCastedGDO<Item, ChipBasket>(),
                    GDOUtils.GetCastedGDO<Item, Salsa>(),
                },
                Max = 2,
                Min = 2,
            }
        };
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override GameObject Prefab => GetPrefab("Chip Basket With Salsa");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Basket", "Raw Pastry");
            prefab.ApplyMaterialToChild("Cloth", "Rug - Red");
            prefab.ApplyMaterialToChild("Bowl", "Plate");
            prefab.ApplyMaterialToChild("Salsa", "Tomato Flesh");
            prefab.ApplyMaterialToChild("Onions", "Onion");
            prefab.ApplyMaterialToChild("1", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("2", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("3", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("4", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("5", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("6", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("7", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("8", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("9", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("10", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("11", "Pie - Mushroom");
        }
    }
}