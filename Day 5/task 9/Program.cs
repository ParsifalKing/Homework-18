
using task_9;

var counter = new Counter();
counter.Increase(); // 1
counter.Increase(); // 2
counter.Decrease(); // 1

counter.Increase(5); // 6
counter.Decrease(3); // 3

System.Console.WriteLine(counter.value);




