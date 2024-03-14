namespace OOP;

public class InMemoryProductRepository
{
    private List<Product> _products;

    public InMemoryProductRepository()
    {
        _products = new List<Product>();  //101
        _products.Add(new Product(1,"Laptop",1));            //Select sorgusu
        _products.Add(new Product(2, "Ütü Masası", 3));
    }


    public List<Product> GetAll()
    {
        return _products;
    }

    public void Add(Product product)
    {
       _products.Add(product);
    }


    //public void Topla(int number1,int number2)
    //{
    //    Console.WriteLine(number1+number2); //geriye değer döndürmeyen method
    //}

    //public string GetName()
    //{
    //    //işlemler
    //    return "Nagihan";  // geriye değer döndüren
    //}


    //public string Add(Product product) // => method overloading
    //{
    //    //işlemler
    //    return "Eklendi"; //+ //product.Id = 1;
    //            // product.CategoryId = 1; ;
    //}

}
