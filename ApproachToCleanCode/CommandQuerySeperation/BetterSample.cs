namespace ApproachToCleanCode.CommandQuerySeperation;

//  Read / write işlemler birbirinden izole. Safety.
// Daha modüler, esnek
// interfaceler küçük.

public interface IOrderCommandRepository
{
    public bool Add(Order order);
    public bool Update(Order order);
}

public interface IOrderQueryRepository
{
    public bool Get(long orderNumber);
}
