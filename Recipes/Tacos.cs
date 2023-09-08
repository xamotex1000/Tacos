using IngredientLib.Ingredient.Items;
using Mexican_Grill.Tacos.Tacos;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace Mexican_Grill.Tacos
{
    public class TacoDish : CustomDish
    {
        public override string UniqueNameID => "Taco Dish";
        public override GameObject DisplayPrefab => GetPrefab("Plated Soft Beef Taco");
        public override GameObject IconPrefab => GetPrefab("Soft Beef Taco");
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override bool IsUnlockable => true;

        public override bool IsAvailableAsLobbyOption => true;
        public override DishType Type => DishType.Base;
        public override List<string> StartingNameSet => new()
        {
            "Taco 'Bout Delicious",
            "Shell Yeah Tacos",
            "Taco 'n' Roll",
            "Shell Shocked",
            "Holy Guacamole",
            "That's a Wrap!",
            "Taco the Town",
            "Let's Taco 'Bout It"
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
            }
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
        };

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Knead Flour Or Add Water To Make Dough, Add Egg To Make A Tortilla, Interact To Shape Into A Shell, Cook To Make A Hard Shell Or Leave Raw For Soft, Add Chopped Steak, Cook, Plate, Serve" }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Tacos", "Adds Tacos as a main", ""))
        };

        public override void OnRegister(Dish gdo)
        {
            gdo.AlsoAddRecipes = new()
            {
                GetCastedGDO<Dish, HardBeefRecipe>(),
                GetCastedGDO<Dish, SoftBeefRecipe>()
            };
            gdo.Difficulty = 2;
        }
    }
}