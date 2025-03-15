namespace EcommercePlatform;

public interface ISearchable
{
    List<Product> SearchProduct(string productName);
    List<Product> SearchCategory(string categoryName);
}
public class ProductsCatalog : ISearchable
{
    private List<Product> _products;
    private List<Category> _categories;
    private Dictionary<string, List<Product>> _categoryProductMap;
    private Dictionary<string, List<Seller>> _productSellerMap;

    public ProductsCatalog()
    {
        _products = new List<Product>();
        _categories = new List<Category>();
        _categoryProductMap = new Dictionary<string, List<Product>>();
        _productSellerMap = new Dictionary<string, List<Seller>>();
        SimilarProducts = new Dictionary<string, List<Product>>();
        SimilarProducts["Dummy Product"] = new List<Product>();
    }

    private void UpdateSimilarProductsMap(Product newProduct)
    {
        string productName = newProduct.Name.ToLower();
        bool isSimilar = false;
        foreach (string key in SimilarProducts.Keys.ToList())
        {
            if (key.ToLower().Contains(productName) || productName.Contains(key.ToLower()))
            {
                isSimilar = true;
                SimilarProducts[key].Add(newProduct);
            }
        }
        if (!isSimilar)
        {
            SimilarProducts[newProduct.Name.ToLower()] = new List<Product> { newProduct };
        }
    }

    private void UpdateCategoryProductMap()
    {
        foreach (Category category in _categories)
        {
            _categoryProductMap[category.Name.ToLower()] = new List<Product>();
        }
    }

    private void UpdateCategoryProductMap(Product product)
    {
        string categoryName = product.Category.Name.ToLower();
        if (_categoryProductMap.ContainsKey(categoryName))
        {
            _categoryProductMap[categoryName].Add(product);
        }
        else
        {
            _categoryProductMap[categoryName] = new List<Product> { product };
        }
    }

    private void UpdateProductSellerMap(Product newProduct)
    {
        string productName = newProduct.Name.ToLower();
        if (_productSellerMap.ContainsKey(productName))
        {
            _productSellerMap[productName].Add(newProduct.Seller);
        }
        else
        {
            _productSellerMap[productName] = new List<Seller> { newProduct.Seller };
        }
    }

    public void AddCategory(Category newCategory)
    {
        _categories.Add(newCategory);
        UpdateCategoryProductMap();
    }

    private Dictionary<string, List<Product>> SimilarProducts { get; set; }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        UpdateProductSellerMap(product);
        UpdateCategoryProductMap(product);
        UpdateSimilarProductsMap(product);
    }

    public override string ToString()
    {
        return $"ProductsCatalog{{_products={string.Join(", ", _products)}}}";
    }

    public List<Product> SearchProduct(string productName)
    {
        SimilarProducts.TryGetValue(productName.ToLower(), out List<Product> result);
        return result;
    }

    public List<Product> SearchCategory(string categoryName)
    {
        _categoryProductMap.TryGetValue(categoryName.ToLower(), out List<Product> result);
        return result;
    }

    public void UpdateProductQuantity(Product product, int newQuantity)
    {
        foreach (Product prod in _products)
        {
            if (prod.Id == product.Id)
            {
                prod.AvailableCount = newQuantity;
            }
        }
    }

    public void RemoveProduct(Product product)
    {
        _products.Remove(product);
    }
}
