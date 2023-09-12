using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Queso{
    public class DoneQueso : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Done Queso";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Pot);
        public override GameObject Prefab => GetPrefab("Done Salsa");
        public override List<Item> SplitDepletedItems => new() { GetGDO<Item>(-486398094) };
        public override Item SplitSubItem => GetCastedGDO<Item, Queso>();
        public override int SplitCount => 5;
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Liquid", "Cheese");
            prefab.ApplyMaterialToChild("Tomato/Skin", "Lettuce");
            prefab.ApplyMaterialToChild("Tomato/Flesh", "Cheese");
            prefab.ApplyMaterialToChild("Tomato/Seeds", "Lettuce");
            prefab.ApplyMaterialToChild("Onions/1", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Onions/2", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Onions/3", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Pot", "Metal");
            prefab.ApplyMaterialToChild("Pot/Handle", "Metal Dark");
        }
    }
}
