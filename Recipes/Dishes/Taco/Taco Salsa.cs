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
    public class SalsaTacoDish : CustomDish
    {
        public static Unlock TacoDish => Find<Unlock>(GDOUtils.GetCustomGameDataObject<TacoDish>().ID);
        public override string UniqueNameID => "Salsa Taco Dish";
        public override GameObject DisplayPrefab => GetPrefab("Salsa");
        public override GameObject IconPrefab => GetPrefab("Salsa");
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsUnlockable => true;
        public override DishType Type => DishType.Base;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new()
            {
                Item = GetCastedGDO<Item, PlatedHardBeefSalsa>(),
                Phase = MenuPhase.Main,
                Weight = 1f
            },
            new()
            {
                Item = GetCastedGDO<Item, PlatedSoftBeefSalsa>(),
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
            GetGDO<Item>(ItemReferences.Tomato),
            GetGDO<Item>(ItemReferences.Onion),
            GetGDO<Item>(ItemReferences.Water),
        };

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Add Salsa To A Finished Taco." }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Salsa Tacos", "Adds Salsa as a Taco Ingredient", ""))
        };
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
		{
            TacoDish
		};

        public override void OnRegister(Dish gdo)
        {
            gdo.Difficulty = 2;
        }
    }
}