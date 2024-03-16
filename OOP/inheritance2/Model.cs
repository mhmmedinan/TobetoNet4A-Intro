using OOP.GenericType;

namespace OOP.inheritance2;

public class Model:BaseEntity<long>
{
    public string Name { get; set; }
    public short BrandId { get; set; }
}
