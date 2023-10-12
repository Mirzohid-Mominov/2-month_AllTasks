namespace N12___T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Car> cars = new List<Car>();

            cars.Add(new Car("Accord", "Honda"));
            cars.Add(new Car("Camry", "Toyota"));
            cars.Add(new Car("Civic", "Honda"));
            cars.Add(new Car("Accord", "Honda"));
            cars.Add(new Car("Elantra", "Hyundai"));
            cars.Add(new Car("Accord", "Honda"));
            cars.Add(new Car("Sonata", "Hyundai"));
            cars.Add(new Car("Elantra", "Hyundai"));
            cars.Add(new Car("Fusion", "Ford"));
            cars.Add(new Car("Malibu", "Chevrolet"));


            Dictionary<Car, int> cars1 = new Dictionary<Car, int>();

            foreach (var car in cars)
            {
                if (!cars1.ContainsKey(car))
                    cars1.Add(car, 1);
                else
                    cars1[car] += 1;

            }

            foreach (var car in cars1)
            {
                if (car.Value > 1)
                {
                    Console.WriteLine("{0} - {1}", car.Key.Name, car.Value);
                }
            }








        }
    }
}