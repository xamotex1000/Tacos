using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Desserts.Churros{
    public class CookedChurroPan : CustomItem
    {
        public override string UniqueNameID => "Cooked Churro Pan";
        public override ItemStorage ItemStorageFlags => ItemStorage.None;
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override Item DisposesTo => GetCastedGDO<Item, ChurroPan>();
        public override List<Item> SplitDepletedItems => new() { GetCastedGDO<Item, ChurroPan>() };
        public override Item SplitSubItem => GetCastedGDO<Item, CookedChurro>();
        public override int SplitCount => 2;
        public override GameObject Prefab => GetPrefab("Filled Churro Tray");
        public override void SetupPrefab(GameObject prefab)
        {
            prefab.ApplyMaterialToChild("Tray", "Metal Very Dark");
            prefab.ApplyMaterialToChild("Inner", "Metal Very Dark");
            prefab.ApplyMaterialToChild("Churro 1", "Pie - Mushroom");
            prefab.ApplyMaterialToChild("Churro 2", "Pie - Mushroom");
        }
        public override void OnRegister(Item gameDataObject)
        {
            LimitedItemSourceView view = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();
            view.DisplayedItems = 2;
            view.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Churro 1"),
                gameDataObject.Prefab.GetChild("Churro 2")
            };
        }
    }
}