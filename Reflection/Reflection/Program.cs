using System;

public class TestClass
{
	public static void Main()
	{
		//  A test class which constructs a Car and prints its details to the console
		Car carObject = new Car("Honda", "City", "2021", "2020", "1,000,000");

		Console.WriteLine("==========Car Details============\n" + carObject.ToString());
	}

	// Implement a Car class which has fields to store the car’s make, model, registration, year, and current value
	public class Car
	{
		private string make;
		private string model;
		private string registration;
		private string year;
		private string currentvalue;

		// Create a empty constructor for the Car class
		public Car()
		{
		}
		// Create a class constructor for the Car class to pass The crossponding values

		public Car(string make, string model, string registration, string year, string currentvalue)
		{
			this.make = make;
			this.model = model;
			this.registration = registration;
			this.year = year;
			this.currentvalue = currentvalue;
		}

		//Get Current Value Method

		public string getCurrentValue()
		{
			return this.currentvalue;
		}

		// Current Year Return Method

		public string getYear()
		{
			return this.year;
		}

		// Overriding ToString to return a string containing full information about the car
		public override string ToString()
		{
			return "Make: " + this.make + "\n"
				+ "Model: " + this.model + "\n"
				+ "Registration: " + this.registration + "\n"
				+ "Model: " + this.year + "\n"
				+ "Current Value: " + this.currentvalue + "\n"
				;
		}
	}
}