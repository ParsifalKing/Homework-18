
using task_8;

var gauge = new Gauge();
gauge.Increase();
gauge.Increase();
gauge.Increase();
gauge.Increase();
gauge.Increase();

System.Console.WriteLine(gauge.GetGauge());

System.Console.WriteLine(gauge.Full());

gauge.Decrease();
System.Console.WriteLine(gauge.GetGauge());


