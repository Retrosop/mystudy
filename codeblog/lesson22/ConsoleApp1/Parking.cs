using System;


namespace Lesson22;

internal class Parking
{
	private List<Car> _cars = new List<Car>();

	private const int MAX_CARS = 100;

	public int Count => _cars.Count;
	public string Name { get; set; }

	public int Add(Car car)
	{
		if (car == null)
		{
			throw new ArgumentNullException(nameof(car), "car is null");
		}
		if (_cars.Count < MAX_CARS)
		{
			_cars.Add(car);
			return _cars.Count - 1;
		}
		return -1;
	}
	public void GoOut(string number)
	{
		if (string.IsNullOrWhiteSpace(number))
		{
			throw new ArgumentNullException(nameof(number), "Number is not null");
		}
		var car = _cars.FirstOrDefault(c => c.Name == number);
		if(car != null)
		{
			_cars.Remove(car);
		}
	}
}
