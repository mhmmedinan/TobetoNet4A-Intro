//Console.WriteLine("Hello, World!");
using OOP;

//Product product = new Product();
//product.Id = 1;
//product.Name = "Laptop";
//product.CategoryId = 1;
//Product product3 = new Product(1,"Ütü Masası",3);


//Console.WriteLine(product3.Name);



//InMemoryProductRepository repository = new InMemoryProductRepository();
//List<Product> products = repository.GetAll();
////foreach(Product productList in products)
////{
////    Console.WriteLine(productList.Id + " " + productList.Name + " " + productList.CategoryId);
////}

//repository.Add(product2);



Product product2 = new Product();
product2.Id = 2;
product2.Name ="Elma";
product2.CategoryId = 2;

ProductManager productManager = new ProductManager();
List<Product> products = productManager.GetAll();
foreach (Product productList in products)
{
    Console.WriteLine(productList.Id + " " + productList.Name + " " + productList.CategoryId);
}

productManager.Add(product2);
foreach (Product productList in products)
{
    Console.WriteLine(productList.Id + " " + productList.Name + " " + productList.CategoryId);
}


////Console.Write("1. sayıyı girin");
////int number1=Convert.ToInt32(Console.ReadLine());

////Console.Write("2. sayıyı girin");
////int number2 = Convert.ToInt32(Console.ReadLine());
////repository.Topla(number1,number2);
//string name = repository.GetName();
//Console.WriteLine(name);



















//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");
//Console.WriteLine("Casper Excalibur G870");

//string productName = "Casper Excalibur G770";
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);


//double unitPrice3 = 27.999;
//var unitPrice1 = 27000;
//var total = unitPrice3 + unitPrice1;

//string productNamee;
//double unitPrice;
//int unitInStock;

////454657484145748
//string identityNumber = "454657484145";
//DateTime year = DateTime.Now;
//Console.WriteLine(year);
//char gender = 'K';
//Console.WriteLine(gender);



//-------------------------------------------------------------------


//int number1 = 150;
//int number2 = 150;

//if (number1 < number2)
//{
//    Console.WriteLine(number1 + ": küçüktür");
//}
//else if (number1 > number2)
//{
//    Console.WriteLine(number1 + ": büyüktür");
//}
//else
//{
//    Console.WriteLine("Sayılar eşittir");
//}


//int assigment = 101;
//if(assigment<=100 && assigment >= 81)
//{
//    Console.WriteLine("AA");
//}
//else if (assigment<=80 && assigment>=71)
//{
//    Console.WriteLine("BA");
//}
//else if(assigment<=70 && assigment >= 51)
//{
//    Console.WriteLine("CC");
//}
//else if(assigment<=50 && assigment >= 40)
//{
//    Console.WriteLine("DD");
//}
//else if(assigment<=40 && assigment >= 0)
//{
//    Console.WriteLine("FF");
//}
//else
//{
//    Console.WriteLine("Geçersiz Sayı");
//}


//Console.Write("Hesap Bakiyenizi Giriniz : ");
//double accountBalance = Convert.ToDouble(Console.ReadLine());

//Console.Write("Çekmek istediğiniz miktarı giriniz : ");
//double amount = Convert.ToDouble(Console.ReadLine());

//if (amount <= accountBalance)
//{
//    accountBalance -= amount;
//    Console.WriteLine("Para çekme işlemi başarılı! Güncel bakiye" + " " + accountBalance);
//}
//else
//{
//    Console.WriteLine("Yetersiz bakiye! İşlem Gerçekleştirilemedi");
//}

//for,foreach,while,do-while
//for(int i = 0; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}

//for(int i = 0; i <= 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine("Çift Sayılar : " + i);
//    }
//    else
//    {
//        Console.WriteLine("Tek Sayılar : "+i);
//    }
//}


//Console.Write("Sınıftaki öğrenci sayısını girin: ");
//int totalStudent = Convert.ToInt32(Console.ReadLine());

//for(int i = 1; i <= totalStudent; i++)
//{
//    Console.Write("Öğrenci adını girin : ");
//    string firstName = Console.ReadLine();

//    Console.Write("Öğrenci soyadını girin : ");
//    string lastName = Console.ReadLine();

//    Console.Write("Sınav 1. notunu girin : ");
//    int number1 = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Sınav 2. notunu girin : ");
//    int number2 = Convert.ToInt32(Console.ReadLine());

//    double totalNumber = (number1 + number2) / 2;

//    Console.WriteLine("Öğrenci :" + firstName + " " + lastName);
//    Console.WriteLine("Not ortalaması : " + totalNumber);
//    Console.WriteLine("----------------------------------");

//}

//int number = 13;
//bool isPrime = true;

//if (number == 1)
//{
//    Console.WriteLine("Sayı asal değildir");
//    return;
//}

//if (number < 2)
//{
//    Console.WriteLine("Geçersiz Sayı");
//    return;
//}

//for(int i = 2; i < number; i++)
//{
//    if (number % i == 0)
//    {
//        isPrime = false;

//    }
//}



//if (isPrime) { Console.WriteLine("Sayı asaldır"); }
//else { Console.WriteLine("Sayı asal değildir"); }











