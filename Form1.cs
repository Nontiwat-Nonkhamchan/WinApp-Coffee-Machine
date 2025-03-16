using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace machineCoffe
{
    public partial class Form1 : Form
    {
        private CoffeeMachine coffeeMachine;

        // เก็บจำนวนครั้งที่กดสั่งแต่ละเมนู (ไม่รีเซ็ตเมื่อเติมวัตถุดิบ)
        private Dictionary<string, int> drinkCount = new Dictionary<string, int>
        {
            { "BlackCoffee", 0 },
            { "Mocha", 0 },
            { "Latte", 0 },
            { "Chocolate", 0 }
        };

        public Form1()
        {
            InitializeComponent();
            coffeeMachine = new CoffeeMachine();
            coffeeMachine.OnIngredientsChanged += UpdateIngredientLabels;
            UpdateIngredientLabels();
        }

        private void UpdateIngredientLabels()
        {
            Dictionary<string, int> ingredients = coffeeMachine.GetIngredients();
            lblWater.Text = $"Water: {ingredients["water"]} g";
            lblCoffee.Text = $"Coffee: {ingredients["coffee"]} g";
            lblChocolate.Text = $"Chocolate: {ingredients["chocolate"]} g";
            lblMilk.Text = $"Milk: {ingredients["milk"]} g";

            // ✅ แสดงจำนวนครั้งที่กดปุ่ม (ไม่รีเซ็ต)
            lblBlackCoffeeCount.Text = $"Black Coffee: {drinkCount["BlackCoffee"]} ครั้ง";
            lblMochaCount.Text = $"Mocha: {drinkCount["Mocha"]} ครั้ง";
            lblLatteCount.Text = $"Latte: {drinkCount["Latte"]} ครั้ง";
            lblChocolateCount.Text = $"Chocolate: {drinkCount["Chocolate"]} ครั้ง";
        }

        private void btnBlackCoffee_Click(object sender, EventArgs e)
        {
            coffeeMachine.MakeDrink("BlackCoffee");
            drinkCount["BlackCoffee"]++;  // ✅ เพิ่มจำนวนครั้งที่กด
            UpdateIngredientLabels();
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            coffeeMachine.MakeDrink("Mocha");
            drinkCount["Mocha"]++;  // ✅ เพิ่มจำนวนครั้งที่กด
            UpdateIngredientLabels();
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            coffeeMachine.MakeDrink("Latte");
            drinkCount["Latte"]++;  // ✅ เพิ่มจำนวนครั้งที่กด
            UpdateIngredientLabels();
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            coffeeMachine.MakeDrink("Chocolate");
            drinkCount["Chocolate"]++;  // ✅ เพิ่มจำนวนครั้งที่กด
            UpdateIngredientLabels();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            coffeeMachine.RefillIngredients(); // เติมวัตถุดิบ

            // ✅ รีเซ็ตจำนวนครั้งที่กดเป็น 0
            drinkCount["BlackCoffee"] = 0;
            drinkCount["Mocha"] = 0;
            drinkCount["Latte"] = 0;
            drinkCount["Chocolate"] = 0;

            UpdateIngredientLabels(); // อัปเดต UI
        }

        private void gbIngredient_Enter(object sender, EventArgs e)
        {

        }
    }
}
