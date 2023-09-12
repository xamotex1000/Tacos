using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Ingredients.Salsa{
    public class DoneSalsa : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "Done Salsa";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetGDO<Item>(ItemReferences.Pot);
        public override GameObject Prefab => GetPrefab("Done Salsa");
        public override List<Item> SplitDepletedItems => new() { GetGDO<Item>(-486398094) };
        public override Item SplitSubItem => GetCastedGDO<Item, Salsa>();
        public override int SplitCount => 5;
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Liquid", "Tomato Flesh");
            prefab.ApplyMaterialToChild("Tomato/Skin", "Tomato");
            prefab.ApplyMaterialToChild("Tomato/Flesh", "Tomato Flesh");
            prefab.ApplyMaterialToChild("Tomato/Seeds", "Tomato Flesh 2");
            prefab.ApplyMaterialToChild("Onions/1", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Onions/2", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Onions/3", "Onion - Flesh", "Onion");
            prefab.ApplyMaterialToChild("Pot", "Metal");
            prefab.ApplyMaterialToChild("Pot/Handle", "Metal Dark");
        }
    }
}