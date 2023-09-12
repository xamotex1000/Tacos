using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Starters.TortillaChips;

namespace Mexican_Grill.Appliances.BasketProvider{
    public class BasketStack : CustomAppliance
    {
        public override string UniqueNameID => "BasketStack";
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemProvider
            {
                Available = 3,
                Maximum = 3,
                Item = GetCastedGDO<Item, Basket>().ID
            }
        };
        public override GameObject Prefab => GetPrefab("Basket Stack");
        public override void SetupPrefab(GameObject prefab)
        {
	    var Collider = prefab.GetComponentInChildren<BoxCollider>();
	    Collider.size = new Vector3(1, 1, 1);;
            prefab.ApplyMaterialToChild("Stand", "Wood 1");
            prefab.ApplyMaterialToChild("Counter", "Wood - Default");
            prefab.ApplyMaterialToChild("Basket/Basket", "Raw Pastry");
            prefab.ApplyMaterialToChild("Basket (1)/Basket", "Raw Pastry");
            prefab.ApplyMaterialToChild("Basket (2)/Basket", "Raw Pastry");
            prefab.ApplyMaterialToChild("Basket/Cloth", "Rug - Red");
            prefab.ApplyMaterialToChild("Basket (1)/Cloth", "Rug - Red");
            prefab.ApplyMaterialToChild("Basket (2)/Cloth", "Rug - Red");
        }

        public override void OnRegister(Appliance gameDataObject)
        {
            LimitedItemSourceView view = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();
            view.DisplayedItems = 2;
            view.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Basket"),
                gameDataObject.Prefab.GetChild("Basket (1)"),
                gameDataObject.Prefab.GetChild("Basket (2)")
            };
        }
    }
}
