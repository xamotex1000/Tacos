using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Appliances.BasketProvider;

namespace Mexican_Grill.Starters.TortillaChips{
    public class Basket : CustomItemGroup<ItemGroupView>
    {
        public override Appliance DedicatedProvider => GetCastedGDO<Appliance, BasketStack>();
        public override string UniqueNameID => "Basket";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override Item DisposesTo => GetCastedGDO<Item, Basket>();
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override GameObject Prefab => GetPrefab("Basket");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Basket", "Raw Pastry");
            prefab.ApplyMaterialToChild("Cloth", "Rug - Red");
        }
    }
}