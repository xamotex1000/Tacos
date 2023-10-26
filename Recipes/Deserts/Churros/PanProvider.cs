using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Desserts.Churros{
    public class ChurroPanProv : CustomAppliance
    {
        public override string UniqueNameID => "Churro Pan Provider";
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemHolder(),
            new CItemProvider
            {
                Available = 1,
                Maximum = 1,
                Item = GetCastedGDO<Item, ChurroPan>().ID,
                AutoPlaceOnHolder = true
            }
        };
        public override List<Appliance.ApplianceProcesses> Processes => new List<Appliance.ApplianceProcesses>
		{
			new Appliance.ApplianceProcesses
			{
				Process = GetGDO<Process>(ProcessReferences.Chop),
				IsAutomatic = false,
				Speed = 0.75f,
				Validity = ProcessValidity.Generic
			},
			new Appliance.ApplianceProcesses
			{
				Process = GetGDO<Process>(ProcessReferences.Knead),
				IsAutomatic = false,
				Speed = 0.75f,
				Validity = ProcessValidity.Generic
			}
		};
        public override GameObject Prefab => GetPrefab("Churro Pan Provider");
        public override void SetupPrefab(GameObject prefab)
        {
	        var Collider = prefab.GetComponentInChildren<BoxCollider>();
	        Collider.size = new Vector3(1, 1, 1);
            prefab.ApplyMaterialToChild("Counter", "Wood 4 - Painted");
            prefab.ApplyMaterialToChild("Counter Doors", "Wood 4 - Painted");
            prefab.ApplyMaterialToChild("Counter Surface", "Wood - Default");
            prefab.ApplyMaterialToChild("Counter Top", "Wood - Default");
            prefab.ApplyMaterialToChild("Handles", "Knob");
            prefab.ApplyMaterialToChild("Tray/Tray", "Metal Very Dark");
            prefab.ApplyMaterialToChild("Tray/Inner", "Metal Very Dark");
        }

        public override void OnRegister(Appliance gameDataObject)
        {
            LimitedItemSourceView view = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();
            view.DisplayedItems = 2;
            view.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Tray")
            };
        }
    }
}
