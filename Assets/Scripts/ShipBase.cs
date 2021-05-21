using System;
using System.Collections.Generic;
using UnityEngine;

public class ShipBase : MonoBehaviour
{
    //Seadragon-Cruiser, Imperator-Carrier
    public enum shipTypes { Corvette = 0, Frigate = 1, Destroyer = 2, Cruiser = 3, Battleship = 4, Carrier = 5, SuperBS = 6, SuperCarrier = 7 }
    [SerializeField] private int maxHull, maxArmor, baseHull, baseArmor, hull, armor;
    [SerializeField] private List<accellPairs> baseAcceleration;
    private Dictionary<string, float> maxAcceleration;
    private Dictionary<string, Dictionary<ModuleBase, float>> percentEffects, thrustEffects;
    private Dictionary<string, Dictionary<ModuleBase, int>> flatEffects;
    public shipTypes shipType;
    string[] effectNames = { "armor", "hull" },
            accellNames = { "forward", "reverse", "sway", "heave", "pitch", "yaw", "roll" };

    [Serializable]
    public struct accellPairs
	{
        public string name;
        public float value;
	}

    #region Getters
    public int GetHull()
    {
        return hull;
    }

    public int GetHullPercent()
    {
        return (int)((float)(hull / maxHull) * 100)/100;
    }

    public int GetArmor()
    {
        return armor;
    }

    public int GetArmorPercent()
    {
        return (int)((float)(armor / maxArmor) * 100)/100;
    }

    public Dictionary<string, float> GetMaxAcceleration()
	{
        return maxAcceleration;
	}
	#endregion

	#region Calculators
	public void CalculateMaxHull()
    {
        maxHull = baseHull;
        foreach (KeyValuePair<ModuleBase, float> module in percentEffects["hull"])
        {
            maxHull += (int)(baseHull * module.Value);
        }
        foreach (KeyValuePair<ModuleBase, int> module in flatEffects["hull"])
        {
            maxHull += module.Value;
        }
    }

    public void CalculateMaxArmor()
    {
        maxArmor = baseArmor;
        foreach (KeyValuePair<ModuleBase, float> module in percentEffects["armor"])
        {
            maxArmor += (int)(baseArmor * module.Value);
        }
        foreach (KeyValuePair<ModuleBase, int> module in flatEffects["armor"])
        {
            maxArmor += module.Value;
        }
    }

    public void CalculateMaxAccel()
	{
        for(int i = 0; i < accellNames.Length; i++)
		{
            float baseAccll = 0;
            for(int v = 0; v < baseAcceleration.Count; v++)
			{
                if(baseAcceleration[v].name == accellNames[i])
				{
                    baseAccll = baseAcceleration[v].value;
                    break;
                }
			}
            maxAcceleration[accellNames[i]] = baseAccll;
            foreach(KeyValuePair<ModuleBase, float> module in thrustEffects[accellNames[i]])
			{
                maxAcceleration[accellNames[i]] += (int)((baseAccll * module.Value) * 10) / 10f;
            }
		}
    }
    #endregion

	public void RegisteModule(ModuleBase module)
	{
        Dictionary<string, float> modulePercents = module.GetPercentEffects(), moduleThrust = module.GetThrustEffects();
        Dictionary<string, int> moduleFlats = module.GetFlatEffects();

        foreach (KeyValuePair<string, float> effect in modulePercents)
        {
            switch (effect.Key)
			{
                case "armor":
                    percentEffects["armor"].Add(module, effect.Value);
                    return;
                case "hull":
                    percentEffects["armor"].Add(module, effect.Value);
                    return;
            }
        }
        foreach (KeyValuePair<string, int> effect in moduleFlats)
        {
            switch (effect.Key)
            {
                case "armor":
                    flatEffects["armor"].Add(module, effect.Value);
                    return;
                case "hull":
                    flatEffects["hull"].Add(module, effect.Value);
                    return;
            }
        }
        foreach (KeyValuePair<string, float> effect in moduleThrust)
        {
            switch (effect.Key)
            {
                case "forward":
                    thrustEffects["forward"].Add(module, effect.Value);
                    return;
                case "reverse":
                    thrustEffects["reverse"].Add(module, effect.Value);
                    return;
                case "sway":
                    thrustEffects["sway"].Add(module, effect.Value);
                    return;
                case "heave":
                    thrustEffects["heave"].Add(module, effect.Value);
                    return;
                case "pitch":
                    thrustEffects["pitch"].Add(module, effect.Value);
                    return;
                case "yaw":
                    thrustEffects["yaw"].Add(module, effect.Value);
                    return;
                case "roll":
                    thrustEffects["roll"].Add(module, effect.Value);
                    return;
            }
        }

        CalculateMaxAccel();
        CalculateMaxArmor();
        CalculateMaxHull();
    }

    public void DeregisterModule(ModuleBase module)
	{
        foreach(KeyValuePair<string, Dictionary<ModuleBase,float>> dictionary in percentEffects)
		{
            dictionary.Value.Remove(module);
		}
        foreach (KeyValuePair<string, Dictionary<ModuleBase, int>> dictionary in flatEffects)
        {
            dictionary.Value.Remove(module);
        }

        CalculateMaxAccel();
        CalculateMaxArmor();
        CalculateMaxHull();
    }

	public void ReplaceModule(ModuleBase oldMod, ModuleBase newMod)
	{
        DeregisterModule(oldMod);
        RegisteModule(newMod);
	}

    public virtual void ShipAction() { }

	private void Start()
	{
        percentEffects = new Dictionary<string, Dictionary<ModuleBase, float>>();
        thrustEffects = new Dictionary<string, Dictionary<ModuleBase, float>>();
        flatEffects = new Dictionary<string, Dictionary<ModuleBase, int>>();
        maxAcceleration = new Dictionary<string, float>();
        for (int i = 0; i < effectNames.Length; i++)
		{
            percentEffects.Add(effectNames[i], new Dictionary<ModuleBase, float>());
            flatEffects.Add(effectNames[i], new Dictionary<ModuleBase, int>());
        }
        for(int i = 0; i < accellNames.Length; i++)
		{
            thrustEffects.Add(accellNames[i], new Dictionary<ModuleBase, float>());
            maxAcceleration.Add(accellNames[i], 0);
        }
        CalculateMaxAccel();
        CalculateMaxArmor();
        CalculateMaxHull();
    }
}
