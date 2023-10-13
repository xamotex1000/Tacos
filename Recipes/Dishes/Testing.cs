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

namespace Mexican_Grill.Testing
{
    public class TestArea : CustomDish
    {
        public override string UniqueNameID => "Testing Area";
        public override GameObject DisplayPrefab => GetPrefab("Chip Basket With Queso");
        public override GameObject IconPrefab => GetPrefab("Chip Basket With Queso");
        public override CardType CardType => CardType.Default;
        public override bool IsUnlockable => false;

        public override bool IsAvailableAsLobbyOption => true;
        public override DishType Type => DishType.Base;
        public override List<string> StartingNameSet => new()
        {
            "Workin' Progress",
            "Error 404 Name Not Found",
            "Appliance Meyhem",
            "Testing Grounds",
            "Provider Delights",
            "Kitty Libra",
            "Spoiler: It Doesn't Work"
        };
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new()
            {
                Item = GetCastedGDO<Item, PlatedHardBeef>(),
                Phase = MenuPhase.Main,
                Weight = 1f
            },
            new()
            {
                Item = GetCastedGDO<Item, PlatedSoftBeef>(),
                Phase = MenuPhase.Main,
                Weight = 1f
            },
            new()
            {
                Item = GetCastedGDO<Item, PlatedHardBeefSalsa>(),
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
            GetCastedGDO<Item, Avocado>()
        };

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "THIS IS JUST A TESTING AREA. IT SHOULD NOT BE USED IN GAMEPLAY" }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Testing", "Dont select this", ""))
        };

        public override void OnRegister(Dish gdo)
        {
            gdo.AlsoAddRecipes = new()
            {
                GetCastedGDO<Dish, HardBeefRecipe>(),
                GetCastedGDO<Dish, SoftBeefRecipe>()
            };
            gdo.Difficulty = 0;
        }
    }
}
