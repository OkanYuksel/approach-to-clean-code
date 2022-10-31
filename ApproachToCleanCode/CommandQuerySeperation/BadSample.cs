namespace ApproachToCleanCode.CommandQuerySeperation;

public interface IOrderRepository
{
    public bool Add(Order order);
    public bool Get(long orderNumber);
    public bool Update(Order order);
}

public class Order
{
    public long OrderNumber { get; set; }
}