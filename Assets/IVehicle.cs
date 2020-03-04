using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicle
{
	string GetName();
}
public class Unicycle : IVehicle
{
	public string GetName()
	{
		return "Unicycle";
	}
}
public class Car : IVehicle
{
	public string GetName()
	{
		return "Car";
	}
}
public class Motorbike : IVehicle
{
	public string GetName()
	{
		return "Motorbike";
	}
}
public class Truck : IVehicle
{
	public string GetName()
	{
		return "Truck";
	}
}
public class Bicycle : IVehicle 
{
	public string GetName()
	{
		return "Bicycle";
	}
}
public class Tandem : IVehicle 
{
	public string GetName()
	{
		return "Tandem";
	}
}
public class Tricycle : IVehicle 
{
	public string GetName()
	{
		return "Tricycle";
	}
}
public class FamilyBike : IVehicle 
{
	public string GetName()
	{
		return "FamilyBike";
	}
}
public class GoKart : IVehicle 
{
	public string GetName()
	{
		return "GoKart";
	}
}
public class Cessna : IVehicle 
{
	public string GetName()
	{
		return "Cessna";
	}
}
public class Boeing747 : IVehicle 
{
	public string GetName()
	{
		return "Boeing747";
	}
}
public class C130 : IVehicle 
{
	public string GetName()
	{
		return "C130";
	}
}
