using task_4;

Order order1 = new Order(101, "Ноутбук", 2, 2500);
Order order2 = new Order("Смартфон", 5);
Order order3 = new Order("Наушники", 120);

Console.WriteLine("Информация о заказах:");
order1.DisplayInfo();
order2.DisplayInfo();
order3.DisplayInfo();
