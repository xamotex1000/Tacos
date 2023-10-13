using IngredientLib.Ingredient.Items;
using Mexican_Grill.Tacos.Tacos;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Appliances.BasketProvider;
using Mexican_Grill.Starters.TortillaChips;

namespace Mexican_Grill.Tacos
{
    public class GuacTacoDish : CustomDish
    {
        public static Unlock TacoDish => Find<Unlock>(GDOUtils.GetCustomGameDataObject<TacoDish>().ID);
        public override string UniqueNameID => "Guac Taco Dish";
        public override GameObject DisplayPrefab => GetPrefab("Plated Soft Beef Salsa Taco");
        public override GameObject IconPrefab => GetPrefab("Plated Soft Beef Salsa Taco");
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsUnlockable => true;
        public override DishType Type => DishType.Base;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new()
            {
                Item = GetCastedGDO<Item, PlatedHardBeefGuac>(),
                Phase = MenuPhase.Main,
                Weight = 1f
            },
            new()
            {
                Item = GetCastedGDO<Item, PlatedSoftBeefGuac>(),
                Phase = MenuPhase.Main,
                Weight = 1f
            },
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GetGDO<Process>(ProcessReferences.Cook),
            GetGDO<Process>(ProcessReferences.Chop),
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            GetGDO<Item>(ItemReferences.Plate),
            GetGDO<Item>(ItemReferences.Meat),
            GetGDO<Item>(ItemReferences.Flour),
            GetGDO<Item>(ItemReferences.Egg),
            GetCastedGDO<Item, Avocado>(),
        };

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Chop Avocado Twice To Mash, Add To A Finished Taco." }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Guacamole Tacos", "Adds Guacamole as a Taco Ingredient", ""))
        };
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
		{
            TacoDish
		};

        public override void OnRegister(Dish gdo)
        {
            gdo.Difficulty = 2;
            IconPrefab.ApplyMaterialToChild("Shell", "Raw Pastry");
            IconPrefab.ApplyMaterialToChild("Spill/Beef", "Meat Piece Cooked", "Meat Piece Cooked");
            IconPrefab.ApplyMaterialToChild("Spill/Beef1", "Meat Piece Cooked", "Meat Piece Cooked");
            IconPrefab.ApplyMaterialToChild("Spill/Beef2", "Meat Piece Cooked", "Meat Piece Cooked");
            IconPrefab.ApplyMaterialToChild("Spill/Beef3", "Meat Piece Cooked", "Meat Piece Cooked");
            IconPrefab.ApplyMaterialToChild("Spill/Beef4", "Meat Piece Cooked", "Meat Piece Cooked");
            IconPrefab.ApplyMaterialToChild("Spill/Salsa", "Avocado Inside", "Avocado Inside");
            IconPrefab.ApplyMaterialToChild("Spill/Salsa1", "Meat Piece Cooked", "Avocado Inside");
            IconPrefab.ApplyMaterialToChild("Spill/Salsa2", "Avocado Inside", "Avocado Inside");
            IconPrefab.ApplyMaterialToChild("Spill/Salsa3", "Avocado Inside", "Avocado Inside");
            IconPrefab.ApplyMaterialToChild("Spill/Salsa4", "Avocado Inside", "Avocado Inside");
            IconPrefab.ApplyMaterialToChild("Spill/Salsa5", "Avocado Inside");
            IconPrefab.ApplyMaterialToChild("Plate", "Plate", "Plate - Ring");
            DisplayPrefab.ApplyMaterialToChild("Shell", "Raw Pastry");
            DisplayPrefab.ApplyMaterialToChild("Spill/Beef", "Meat Piece Cooked", "Meat Piece Cooked");
            DisplayPrefab.ApplyMaterialToChild("Spill/Beef1", "Meat Piece Cooked", "Meat Piece Cooked");
            DisplayPrefab.ApplyMaterialToChild("Spill/Beef2", "Meat Piece Cooked", "Meat Piece Cooked");
            DisplayPrefab.ApplyMaterialToChild("Spill/Beef3", "Meat Piece Cooked", "Meat Piece Cooked");
            DisplayPrefab.ApplyMaterialToChild("Spill/Beef4", "Meat Piece Cooked", "Meat Piece Cooked");
            DisplayPrefab.ApplyMaterialToChild("Spill/Salsa", "Avocado Inside", "Avocado Inside");
            DisplayPrefab.ApplyMaterialToChild("Spill/Salsa1", "Meat Piece Cooked", "Avocado Inside");
            DisplayPrefab.ApplyMaterialToChild("Spill/Salsa2", "Avocado Inside", "Avocado Inside");
            DisplayPrefab.ApplyMaterialToChild("Spill/Salsa3", "Avocado Inside", "Avocado Inside");
            DisplayPrefab.ApplyMaterialToChild("Spill/Salsa4", "Avocado Inside", "Avocado Inside");
            DisplayPrefab.ApplyMaterialToChild("Spill/Salsa5", "Avocado Inside");
            DisplayPrefab.ApplyMaterialToChild("Plate", "Plate", "Plate - Ring");
        }
    }
}