using System.Collections.Generic;
using System.Collections;
using Delegates2;

List<ShoppingItems> products = new List<ShoppingItems>();
Discount discount = new Discount();



Discount.DiscountNumber cunt2 = new Discount.DiscountNumber(discount.Test);
Discount.PriceTotal pricetot = new Discount.PriceTotal(DiscountNum);

DummyData();
pricetot(products);



decimal DiscountNum(List<ShoppingItems> item)
{
    decimal discNum = 0m;
    decimal subTotal =  0m;
    foreach (ShoppingItems item2 in products)
    {
        Console.WriteLine(item2.Name);
        subTotal += item2.Price;
       
    }
    if (subTotal > 9)
    {
        discNum = subTotal * 0.7m;
    } else if (subTotal > 5)
    {
        discNum = subTotal * 0.7m;
    } 
    Console.WriteLine("Total Price Cart: {0}", subTotal);
    Console.WriteLine("Discount Applied: {0}", discNum);
    return subTotal;
    
}

 void DummyData()
{
    products.Add(new ShoppingItems { Name = "Bread", Price = 1.29M});
    products.Add(new ShoppingItems { Name = "Milk", Price = 0.85M });
    products.Add(new ShoppingItems { Name = "Eggs", Price = 2.23M });
    products.Add(new ShoppingItems { Name = "Flour", Price = 0.79M });
    products.Add(new ShoppingItems { Name = "Cheese", Price = 4.20M });
};
