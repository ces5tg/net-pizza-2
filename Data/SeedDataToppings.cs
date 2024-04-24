namespace BlazingPizza.Data;

internal static class SeedDataToppings
{
    internal static Task InitializeAsync(PizzaStoreContext db)
    {
        Topping[] toppings =
        [
            new()
            {
                Id = 1,
                Name = "Mayonesa",
                Price = 1.99m
            },
            new()
            {
                Id = 2,
                Name = "Mas quesito :)",
                Price = 2.99m
            },
            new()
            {
                Id = 3,
                Name = "Mas salame :)",
                Price = 3.99m
            },
            new()
            {
                Id = 4,
                Name = "Doritos",
                Price = 0.99m
            }

           
        ];
        db.Toppings.AddRange(toppings);
        return db.SaveChangesAsync();
    }
}