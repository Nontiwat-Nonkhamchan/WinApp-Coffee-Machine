using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineCoffe
{
    internal class CoffeeMachine
    {
        //เก็บจำนวณวัตถุดิบ
        private Dictionary<string, int> ingredients;
        // Constructor สำหรับกำหนดค่าเริ่มต้น
        public CoffeeMachine()
        {
            ingredients = new Dictionary<string, int>
            {
                { "water", 2000 },
                { "coffee", 500 },
                { "chocolate", 300 },
                { "milk", 500 }
            };
        }
        //สูตรเครื่องดื่ม
        private Dictionary<string, Dictionary<string, int>> recipes = new Dictionary<string, Dictionary<string, int>>
        {
            { "BlackCoffee", new Dictionary<string, int> { { "water", 300 }, { "coffee", 20 } } },
            { "Mocha", new Dictionary<string, int> { { "water", 300 }, { "coffee", 20 }, { "chocolate", 10 } } },
            { "Latte", new Dictionary<string, int> { { "water", 300 }, { "coffee", 20 }, { "milk", 10 } } },
            { "Chocolate", new Dictionary<string, int> { { "water", 300 }, { "chocolate", 20 } } }
        };

       //เเจ้งว่าวัตถุดิบเปลี่ยนแปลง
        public event Action OnIngredientsChanged;


       //คืนค่าวัตถุดิบ
        public Dictionary<string, int> GetIngredients()
        {
          return new Dictionary<string, int>(ingredients);
        }

       //ตรวจสอบวัตถุดิบ
       private bool CheckIngredients(string drink)
       {
           if (!recipes.ContainsKey(drink))
           {
               MessageBox.Show("ไม่มีเครื่องดื่มนี้ในเมนู");
               return false;
           }

           foreach (var item in recipes[drink])
           {
               if (ingredients[item.Key] < item.Value)
               {
                   MessageBox.Show($"{item.Key} ไม่เพียงพอสำหรับการชง{drink}");
                   return false;
               }
           }
           return true;
       }

       //ฟังชันก์ชงเครื่องดื่ม
       public void MakeDrink(string drink)
       {
           if (!CheckIngredients(drink))
           {
               return;
           }

           foreach (var item in recipes[drink])
           {
               ingredients[item.Key] -= item.Value;
           }

           MessageBox.Show($"{drink} พร้อมเสิร์ฟเเล้วค่ะ");
           OnIngredientsChanged?.Invoke();  // แจ้งให้ UI อัปเดตวัตถุดิบ
       }

       // ฟังก์ชันเติมวัตถุดิบ
       public void RefillIngredients()
       {
           ingredients["water"] = 2000;
           ingredients["coffee"] = 500;
           ingredients["chocolate"] = 300;
           ingredients["milk"] = 500;
           MessageBox.Show("เติมวัตถุดิบเรียบร้อยแล้วค่ะ");
           OnIngredientsChanged?.Invoke();  // แจ้งให้ UI อัปเดตวัตถุดิบ

        }
    }
}
