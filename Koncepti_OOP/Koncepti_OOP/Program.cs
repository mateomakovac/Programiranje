using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koncepti_OOP
{
    namespace Koncepti_OOP
    {
        public class FoodType
        {
            private string name;
            private int protein;
            private int carbs;
            private int fat;
            private static int counter = 0;

            public FoodType(string name, int protein, int carbs, int fat)
            {
                this.name = name;
                this.protein = protein;
                this.carbs = carbs;
                this.fat = fat;
                counter++;
            }

            public string Name { get { return name; } }
            public int Protein { get { return protein; } }
            public int Carbs { get { return carbs; } }
            public int Fat { get { return fat; } }

            

            public override string ToString()
            {
                return $"{name}: p - {protein}%, c - {carbs}%, f - {fat}%";
            }
        }

        public class Food
        {
            private FoodType type;
            private int weight;

            public Food(FoodType type, int weight)
            {
                this.type = type;
                this.weight = weight;
            }

            public FoodType Type { get { return type; } }
            public int Weight { get { return weight; } }

            public double GetProteinInGrams()
            {
                return type.Protein * weight / 100.0;
            }

            public double GetCarbsInGrams()
            {
                return type.Carbs * weight / 100.0;
            }

            public double GetFatInGrams()
            {
                return type.Fat * weight / 100.0;
            }

            public override string ToString()
            {
                return $"{type.ToString()}, w - {weight}g";
            }

            public string ToStringInGrams()
            {
                return $"{type.Name}: proteini - {GetProteinInGrams():F1}g, carb - {GetCarbsInGrams():F1}g, f - {GetFatInGrams():F1}g, w - {weight}g";
            }
        }



        class Koncept
        {
            static void Main()
            {
                FoodType bananaType = new FoodType("banana", 4, 93, 3);
                Food banana = new Food(bananaType, 110);

                Console.WriteLine(bananaType.ToString());
                Console.WriteLine(banana.ToString());
                Console.WriteLine(banana.ToStringInGrams());            
                Console.ReadKey();
            }
        }
    }

}
