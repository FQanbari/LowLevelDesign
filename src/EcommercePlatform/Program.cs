// Creating Customer --> Piyush
using EcommercePlatform;

Customer piyush = new Customer("Piyush Khandelwal", "9876987655");

// Creating Seller --> Daily Needs Groceries
Seller dailyNeedsGrocery = new Seller("Daily Needs Groceries", "9876543210");

// Creating Seller --> Fashion Point
Seller fashionPoint = new Seller("Fashion Point", "9988776655");

// Creating Seller --> Digi Electronics
Seller digiElectronics = new Seller("Digi Electronics", "9876598765");
Seller homeSeller = new Seller("Home Desing", "9107606155");

// Creating category --> Electronics
Category electronics = new Category("Electronics");

// Creating category --> Cosmetics
Category cosmetics = new Category("Cosmetics");

// Creating category --> Grocery
Category grocery = new Category("Groceries");

// Creating category --> Clothing
Category clothing = new Category("Clothing");

MyFlipKart myFlipKart = new MyFlipKart();

// Adding all the _categories to Flipkart catalog
myFlipKart.ProductsCatalog.AddCategory(clothing);
myFlipKart.ProductsCatalog.AddCategory(grocery);
myFlipKart.ProductsCatalog.AddCategory(cosmetics);
myFlipKart.ProductsCatalog.AddCategory(electronics);

// Seller Digi Electronics adding Mobile to myFlipKart catalog
digiElectronics.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Mobile", "Latest Technology", 10000.00, electronics, 5));

homeSeller.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Table", "Squar Table", 17000.00, new Category("Home"), 5));

// Seller Digi Electronics adding Camera to myFlipKart catalog
digiElectronics.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Camera", "Advanced Technology", 50000.00, electronics, 10));

// Seller FashionPoint adding Wearables to myFlipKart catalog
fashionPoint.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Mens Jackets", "XL - Size", 1000.00, clothing, 10));

fashionPoint.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Jackets", "XL - Size", 1000.00, clothing, 10));

// Seller FashionPoint adding Cosmetics to myFlipKart catalog
fashionPoint.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Nail Paint", "Red Color", 500.00, cosmetics, 25));

// Seller dailyNeedsGrocery adding grocery to myFlipKart catalog
dailyNeedsGrocery.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Sugar", "Fine quality", 40.00, grocery, 1000));

dailyNeedsGrocery.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Milk", "100% Pure", 50.00, grocery, 250));

dailyNeedsGrocery.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Toned Milk", "Hygienic and Pure", 45.00, grocery, 250));

dailyNeedsGrocery.RegisterProduct(myFlipKart.ProductsCatalog,
    new Product("Milk Cream", "Natural", 145.00, grocery, 100));

// Customer searching for product --> milk
List<Product> milkResults = myFlipKart.ProductsCatalog.SearchProduct("Milk");

// Customer searching for all the _products in grocery
List<Product> groceryProducts = myFlipKart.ProductsCatalog.SearchCategory("Groceries");

// Customer adding 10 packets of milk to _cart
Item milkTenPackets = new Item(milkResults[0], 10);
piyush.AddItemToCart(milkTenPackets);

// Printing current _cart _status
piyush.PrintCartItems();

// Customer searching for another product --> camera
List<Product> cameraResults = myFlipKart.ProductsCatalog.SearchProduct("CaMeRa");

// Customer adding 1 camera to _cart
Item oneCamera = new Item(cameraResults[0], 1);
piyush.AddItemToCart(oneCamera);

// Printing current _cart _status
piyush.PrintCartItems();

// Customer updating quantity of milk packets from 10 to 15
piyush.UpdateItemCount(milkTenPackets, 15);

// Printing current _cart _status
piyush.PrintCartItems();

// Customer placing the order
piyush.PlaceOrder();

// Customer _cart is empty after checkout
piyush.PrintCartItems();

// Printing the current Order of customer
Console.WriteLine(piyush.CurrentOrder);

// Customer order is moved to shipment
Shipment s = piyush.CurrentOrder.MoveToShipment();

// Printing the shipment details
Console.WriteLine(s);

s.PrintOrderLog();