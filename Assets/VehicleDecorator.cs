using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class VehicleDecorator : IVehicle
{
	protected IVehicle m_DecoratedVehicle;

	public VehicleDecorator(IVehicle vehicle)
	{
		m_DecoratedVehicle = vehicle;
	}

	public virtual string GetName()
	{
		return m_DecoratedVehicle.GetName();
	}
}

public class WithOrnament : VehicleDecorator
{
	public WithOrnament(IVehicle vehicle) : base(vehicle) { }

	public override string GetName()
	{
		return base.GetName() + " With Hood Ornament";
	}
}

public class WithMissles : VehicleDecorator
{
	public WithMissles(IVehicle vehicle) : base(vehicle) { }

	public override string GetName()
	{
		return base.GetName() + " With missles";
	}
}

public class WithAirFreshener : VehicleDecorator
{
	public WithAirFreshener(IVehicle vehicle) : base(vehicle) { }

	public override string GetName()
	{
		return base.GetName() + " With Air Freshener";
	}
}