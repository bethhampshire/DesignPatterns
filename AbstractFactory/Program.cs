using AbstractFactory;

Console.Title = "Abstract Factory";

var begiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var shoppingCartForBelgium = new ShoppingCart(begiumShoppingCartPurchaseFactory);
shoppingCartForBelgium.CalculateCosts();

var frenchShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(frenchShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

Console.ReadKey();