class Program
{
    static void Main()
    {
        Worker worker1 = new Worker("Горбунов Ким Андреевич", "Босс", 100000000);
        Worker worker2 = new Worker("Кравчук Михаил Сергеевич", "Менеджер", 20000);
        Worker worker3 = new Worker("Арсланов Роман Евгеньевич", "Айтышник", 50000);
        Worker worker4 = new Worker("Калугин Иван Анатольевич", "Айтышник", 100000);
        Worker worker5 = new Worker("Денисов Егор Алексеевич", "Менеджер", 30000);

        List<Worker> listOfWorkers = [worker1, worker2, worker3, worker4, worker5];

        Console.Write("Введите зарплату: ");
        string InputSalary = Console.ReadLine();
        Console.Write("Работники, зарплата которых больше заданной: ");
        for (int i = 0; i < listOfWorkers.Count; i++)
        {
            if (listOfWorkers[i].Salary > Convert.ToInt32(InputSalary))
            {
                Console.Write($"{listOfWorkers[i].FullName}  ");
            }
        }

        Console.WriteLine();
        Console.Write("Введите должность: ");
        string InputPost = Console.ReadLine();
        Console.Write("Работники, занимающих заданную должность: ");
        for (int i = 0; i < listOfWorkers.Count; i++)
        {
            if (listOfWorkers[i].Post.Equals(InputPost))
            {
                Console.Write($"{listOfWorkers[i].FullName}  ");
            }
        }
    }
}