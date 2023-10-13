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
    public class GuacChipDish : CustomDish
    {
        public static Unlock ChipDish => Find<Unlock>(GDOUtils.GetCustomGameDataObject<ChipDish>().ID);
        public override string UniqueNameID => "Tortilla Chips Dish With Guac";
        public override GameObject DisplayPrefab => GetPrefab("Chip Basket With Guac");
        public override GameObject IconPrefab => GetPrefab("Chip Basket With Guac");
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
                Item = GetCastedGDO<Item, ChipBasketGuac>(),
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
            GetCastedGDO<Item, Avocado>()

        };

        public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Knead Flour and Add Egg to Make a Tortilla, Cook the Tortilla and Chop to Make Tortilla Chips. Chop Avocado Twice to Make Guacamole. Add Both to Basket and Serve." }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, CreateUnlockInfo("Tortilla Chips W/ Guac", "Adds Tortilla Chips and Guacamole as a starter", ""))
        };

        public override void OnRegister(Dish gdo)
        {
            gdo.Difficulty = 2;
            IconPrefab.ApplyMaterialToChild("Basket", "Raw Pastry");
            IconPrefab.ApplyMaterialToChild("Cloth", "Rug - Red");
            IconPrefab.ApplyMaterialToChild("Bowl", "Plate");
            IconPrefab.ApplyMaterialToChild("Guac", "Avocado Inside");
            IconPrefab.ApplyMaterialToChild("1", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("2", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("3", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("4", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("5", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("6", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("7", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("8", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("9", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("10", "Pie - Mushroom");
            IconPrefab.ApplyMaterialToChild("11", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("Basket", "Raw Pastry");
            DisplayPrefab.ApplyMaterialToChild("Cloth", "Rug - Red");
            DisplayPrefab.ApplyMaterialToChild("Bowl", "Plate");
            DisplayPrefab.ApplyMaterialToChild("Guac", "Avocado Inside");
            DisplayPrefab.ApplyMaterialToChild("1", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("2", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("3", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("4", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("5", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("6", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("7", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("8", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("9", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("10", "Pie - Mushroom");
            DisplayPrefab.ApplyMaterialToChild("11", "Pie - Mushroom");
        }
    }
}