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
using Mexican_Grill.Ingredients.Salsa;

namespace Mexican_Grill.Starters.TortillaChips
{
    public class SalsaChipDish : CustomDish
    {
        public static Unlock ChipDish => Find<Unlock>(GDOUtils.GetCustomGameDataObject<ChipDish>().ID);
        public override string UniqueNameID => "Tortilla Chips Dish With Salsa";
        public override GameObject DisplayPrefab => GetPrefab("Chip Basket With Salsa");
        public override GameObject IconPrefab => GetPrefab("Chip Basket With Salsa");
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
                Item = GetCastedGDO<Item, ChipBasketSalsa>(),
                Phase = MenuPhase.Starter,
                Weight = 1f
            }
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            GetGDO<Process>(ProcessReferences.Cook),
            GetGDO<Process>(ProcessReferences.Chop),
        };
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
		{
            ChipDish
		};
        public override HashSet<Item> MinimumIngredients => new()
        {
            GetGDO<Item>(ItemReferences.Flour),
            GetGDO<Item>(ItemReferences.Egg),
            GetCastedGDO<Item, Basket>(),
            GetGDO<Item>(ItemReferences.Tomato),
            GetGDO<Item>(ItemReferences.Onion),
            GetGDO<Item>(ItemReferences.Pot),

        };

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Knead Flour and Add Egg to Make a Tortilla, Cook the Tortilla and Chop to Make Tortilla Chips. Add Water, Chopped Tomatoes, and Chopped Onions to Pot, Chop Pot, Add Both to Basket and Serve." }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Tortilla Chips W/ Salsa", "Adds Tortilla Chips and Salsa as a starter", ""))
        };

        public override void OnRegister(Dish gdo)
        {
            gdo.AlsoAddRecipes = new()
            {
                GetCastedGDO<Dish, SalsaRecipe>()
            };
            gdo.Difficulty = 2;
        }
    }
}