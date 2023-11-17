using System.Diagnostics;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Foods.Any()) return;

            var foods = new List<Food>
            {
                new Food
                {
                    Name = "Vegan Pizza",
                    Ingredients = "Dough, tomato sauce, vegan cheese, vegan pepperoni",
                    Directions = "Make the dough, add the sauce, add the cheese, add the pepperoni, bake it",
                    Description = "A delicious vegan pizza",
                    Rating = 5,
                    Category = "Italian"
                },
                new Food
                {
                    Name = "Vegan Pasta",
                    Ingredients = "Pasta, tomato sauce, vegan cheese, vegan meatballs",
                    Directions = "Boil the pasta, add the sauce, add the cheese, add the meatballs",
                    Description = "A delicious vegan pasta",
                    Rating = 5,
                    Category = "Italian"
                },
                
                new Food
                {
                    Name = "Vegan Burger",
                    Ingredients = "Bun, vegan patty, lettuce, tomato, onion, vegan cheese, vegan mayo",
                    Directions = "Toast the bun, cook the patty, add the lettuce, tomato, onion, cheese, mayo",
                    Description = "A delicious vegan burger",
                    Rating = 2,
                    Category = "American"
                },
                new Food
                {
                    Name = "Vegan Hot Dog",
                    Ingredients = "Bun, vegan hot dog, ketchup, mustard, relish, onion",
                    Directions = "Toast the bun, cook the hot dog, add the ketchup, mustard, relish, onion",
                    Description = "A delicious vegan hot dog",
                    Rating = 3,
                    Category = "American"
                },
                new Food
                {
                    Name = "Vegan Sushi",
                    Ingredients = "Rice, seaweed, cucumber, avocado, carrot, vegan mayo",
                    Directions = "Cook the rice, add the seaweed, cucumber, avocado, carrot, mayo",
                    Description = "A delicious vegan sushi",
                    Rating = 1,
                    Category = "Japanese"
                },
                new Food
                {
                    Name = "Vegan Ramen",
                    Ingredients = "Ramen noodles, vegetable broth, tofu, mushrooms, seaweed, green onion",
                    Directions = "Cook the noodles, add the broth, tofu, mushrooms, seaweed, green onion",
                    Description = "A delicious vegan ramen",
                    Rating = 5,
                    Category = "Japanese"
                },
                new Food
                {
                    Name = "Vegan Curry",
                    Ingredients = "Rice, vegetable broth, tofu, potatoes, carrots, onion, curry powder",
                    Directions = "Cook the rice, add the broth, tofu, potatoes, carrots, onion, curry powder",
                    Description = "A delicious vegan curry",
                    Rating = 5,
                    Category = "Indian"
                },
                new Food
                {
                    Name = "Vegan Samosa",
                    Ingredients = "Potatoes, peas, onion, curry powder, dough",
                    Directions = "Cook the potatoes, peas, onion, curry powder, wrap in dough, bake",
                    Description = "A delicious vegan samosa",
                    Rating = 4,
                    Category = "Indian"
                },
                new Food
                {
                    Name = "Vegan Tacos",
                    Ingredients = "Tortilla, beans, lettuce, tomato, onion, vegan cheese, vegan sour cream",
                    Directions = "Cook the beans, add the lettuce, tomato, onion, cheese, sour cream",
                    Description = "A delicious vegan taco",
                    Rating = 3,
                    Category = "Mexican"
                },
                new Food
                {
                    Name = "Vegan Burrito",
                    Ingredients = "Tortilla, beans, rice, lettuce, tomato, onion, vegan cheese, vegan sour cream",
                    Directions = "Cook the beans, rice, add the lettuce, tomato, onion, cheese, sour cream",
                    Description = "A delicious vegan burrito",
                    Rating = 4,
                    Category = "Mexican"
                }
            };

            await context.Foods.AddRangeAsync(foods);
            await context.SaveChangesAsync();
        }
    }

}