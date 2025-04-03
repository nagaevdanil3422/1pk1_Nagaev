namespace Task_20_03
{
    /*  Создайте программу для управления статусом заказа в интернет-магазине. Используйте перечисление OrderStatus со значениями:
        • New (новый)
        • Processing (в обработке)
        • Shipped (отправлен)
        • Delivered (доставлен)
        • Cancelled (отменён)
        Напишите метод, который меняет статус заказа. Если заказ уже доставлен или отменён, запретите изменение статуса.
        Выводите сообщение при каждом изменении статуса 
        (например,"Заказ переведён в статус: Отправлен").
    */
    public enum OrderStatus
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
    public class Order
    {
        public int OrderId { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            Status = OrderStatus.New;
        }
        public void ChangeStatus(OrderStatus newStatus)
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
            {
                Console.WriteLine("Невозможно изменить статус. Заказ уже доставлен или отменён.");
                return;
            }
            Status = newStatus;
            Console.WriteLine($"Заказ {OrderId} переведён в статус: {Status}");
        }



        static void Main(string[] args)
        {
            Order order = new Order(1);
            order.ChangeStatus(OrderStatus.Processing);
            order.ChangeStatus(OrderStatus.Shipped);
            order.ChangeStatus(OrderStatus.Delivered);
            order.ChangeStatus(OrderStatus.Cancelled);
            Console.WriteLine($"Текущий статус заказа: {order.Status}");
        }
    }
}