namespace OOP;

public class ProductManager
{
    private InMemoryProductRepository _repository;

    public ProductManager()
    {
        _repository = new InMemoryProductRepository();
    }

    public void Add(Product product)
    {
        if (product.Name is null)
        {
            throw new Exception("Product Name boş olamaz");
        }
        else if (productNameIsExists(product.Name))
        {
            throw new Exception($"Product name is exists.");
        }
      
        else { _repository.Add(product); }
    }


    public List<Product> GetAll()
    {
        return _repository.GetAll();
    }


    private bool productNameIsExists(string productName)
    {
        foreach(Product product in GetAll()) 
        {
            if (product.Name.Equals(productName))
            {
                return true;
            }
        }
        return false;
    }
}

