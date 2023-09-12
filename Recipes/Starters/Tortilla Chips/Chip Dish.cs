using IngredientLib.Ingredient.Items;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using Mexican_Grill.Tacos;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mexican_Grill.Starters.TortillaChips
{
    public class ChipDish : CustomDish
    {
        public static Unlock TacoDish => Find<Unlock>(GDOUtils.GetCustomGameDataObject<TacoDish>().ID);
        public override string UniqueNameID => "Tortilla Chips Dish";
        public override int MaxOrderSharers => 999;
        public override GameObject DisplayPrefab => GetPrefab("Chip Basket");
        public override GameObject IconPrefab => GetPrefab("Chip Basket");
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsUnlockable => true;

        public override DishType Type => DishType.Starter;

        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new()
            {
                Item = GetCastedGDO<Item, ChipBasket>(),
                Phase = MenuPhase.Starter,
                Weight = 0.75f
            }
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            GetGDO<Process>(ProcessReferences.Cook),
            GetGDO<Process>(ProcessReferences.Chop),
        };
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
		{
            TacoDish
		};
        public override HashSet<Item> MinimumIngredients => new()
        {
            GetGDO<Item>(ItemReferences.Flour),
            GetGDO<Item>(ItemReferences.Egg),
            GetCastedGDO<Item, Basket>(),
        };

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Knead Flour and Add Egg to Make a Tortilla, Cook the Tortilla and Chop to Make Tortilla Chips. Add to Basket and Serve." }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Tortilla Chips", "Adds Tortilla Chips as a starter", ""))
        };

        public override void OnRegister(Dish gdo)
        {
            gdo.Difficulty = 2;
        }
    }
}