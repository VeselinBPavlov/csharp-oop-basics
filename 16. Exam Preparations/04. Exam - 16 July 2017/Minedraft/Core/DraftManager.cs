using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private string currentMode;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();
        this.currentMode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var harvester = harvesterFactory.CreateHarvester(arguments);
        harvesters.Add(harvester);

        return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        var provider = providerFactory.CreateProvider(arguments);
        providers.Add(provider);

        return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
    }

    public string Day()
    {
        double summedEnergyOutput = providers.Sum(x => x.EnergyOutput);
        totalStoredEnergy += summedEnergyOutput;
        double summedEnergyRequirement = harvesters.Sum(x => x.EnergyRequirement);
        double summedOreOutput = 0;

        switch (this.currentMode)
        {
            case "Full":
                {
                    if (totalStoredEnergy >= summedEnergyRequirement)
                    {
                        totalStoredEnergy -= summedEnergyRequirement;
                        summedOreOutput += harvesters.Sum(x => x.OreOutput);                        
                    }
                }
                break;
            case "Half":
                {
                    summedEnergyRequirement *= 0.6;
                    if (totalStoredEnergy >= summedEnergyRequirement)
                    {
                        totalStoredEnergy -= summedEnergyRequirement;
                        summedOreOutput += harvesters.Sum(x => x.OreOutput) * 0.5;
                    }
                }
                break;
            case "Energy": break;
        }

        totalMinedOre += summedOreOutput;

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {summedEnergyOutput}");
        sb.AppendLine($"Plumbus Ore Mined: {summedOreOutput}");
        return sb.ToString().TrimEnd();
    }

    public string Mode(List<string> arguments)
    {
        this.currentMode = arguments[0];
        return $"Successfully changed working mode to {arguments[0]} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        var harvester = harvesters.FirstOrDefault(x => x.Id == id);
        var provider = providers.FirstOrDefault(x => x.Id == id);
        if (harvester != null)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{harvester.Type} Harvester - {harvester.Id}");
            sb.AppendLine($"Ore Output: {harvester.OreOutput}");
            sb.AppendLine($"Energy Requirement: {harvester.EnergyRequirement}");

            return sb.ToString().TrimEnd();
        }

        if (provider != null)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{provider.Type} Provider - {provider.Id}");
            sb.AppendLine($"Energy Output: {provider.EnergyOutput}");

            return sb.ToString().TrimEnd();
        }

        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");
        return sb.ToString().TrimEnd();
    }
}

