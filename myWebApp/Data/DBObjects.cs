using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Prices.Any())
            {
                content.AddRange(
                        new Prices { dish = "Thorny Rose", price = 10.0f },
                        new Prices { dish = "Ohh La La", price = 8.0f },
                        new Prices { dish = "Fancy pants", price = 7.0f },
                        new Prices { dish = "Stella Artois", price = 5.0f },
                        new Prices { dish = "La Chouffe", price = 5.0f },
                        new Prices { dish = "Duvel", price = 6.0f },
                        new Prices { dish = "Hobgoblin ale", price = 5.0f },
                        new Prices { dish = "Newcastle brown ale", price = 4.0f },
                        new Prices { dish = "500g Steak", price = 15.0f },
                        new Prices { dish = "Grilled cheese burger", price = 20.0f },
                        new Prices { dish = "Grilled Pork Loin", price = 15.0f },
                        new Prices { dish = "BBQ Ribs", price = 15.0f },
                        new Prices { dish = "Sirloin Burger", price = 20.0f },
                        new Prices { dish = "Smoked Chicken", price = 18.0f },
                        new Prices { dish = "Grilled Lamb", price = 15.0f },
                        new Prices { dish = "Roasted Salmon", price = 24.0f },
                        new Prices { dish = "Fried sprouts", price = 5.0f },
                        new Prices { dish = "Mashed potatoes", price = 5.0f },
                        new Prices { dish = "Grilled carrots", price = 7.0f },
                        new Prices { dish = "Brownies", price = 5.0f },
                        new Prices { dish = "Strawberry ice cream", price = 5.0f },
                        new Prices { dish = "Sweet potatoes", price = 5.0f },
                        new Prices { dish = "Cheesecase", price = 5.0f },
                        new Prices { dish = "Banana Ice cream", price = 7.0f },
                        new Prices { dish = "Seafood salad", price = 11.0f },
                        new Prices { dish = "Shrimp salad", price = 10.0f },
                        new Prices { dish = "Bacon & cheese salad", price = 10.0f },
                        new Prices { dish = "Caesar salad", price = 13.0f },
                        new Prices { dish = "Sirloin tacos", price = 9.0f },
                        new Prices { dish = "Garlic noodles", price = 7.0f },
                        new Prices { dish = "Chicken wings", price = 9.0f },
                        new Prices { dish = "Guacamole & chips", price = 7.0f }
                );
            }
            content.SaveChanges();
        }
    }
}
