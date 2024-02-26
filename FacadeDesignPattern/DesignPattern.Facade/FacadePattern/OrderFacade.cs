using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();

        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void CompleteOrder(int customerID, int productId, int orderID, int productCount, decimal productPrice) //siparişi tamamlayacak metot
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);

            orderDetail.OrderID = orderID;
            orderDetail.CustomerID = customerID;
            orderDetail.ProductID = productId;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            decimal totalProductPrice = productCount * productPrice;
            orderDetail.ProductTotalPrice = totalProductPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productId, productCount);
        }
    }
}
