using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider
{
    // Fields.
    private double energyOutput;

    // Properties.
    public string Id { get; private set; }

    public double EnergyOutput
    {
        get => this.energyOutput;
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }

    public virtual string Type => "";

    // Constructor.
    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }
}

