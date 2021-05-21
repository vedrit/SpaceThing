using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleBase : MonoBehaviour
{
    public enum moduleType { Armor = 0, Hull = 1, Weapon = 2, System = 3, Crew = 4 }
    public moduleType type;
    [SerializeField] private Dictionary<string, float> percentEffects, thrustEffects;
    [SerializeField] private Dictionary<string, int> flatEffects;

    public Dictionary<string, float> GetPercentEffects()
    {
        return percentEffects;
    }

    public Dictionary<string, float> GetThrustEffects()
    {
        return thrustEffects;
    }

    public Dictionary<string, int> GetFlatEffects()
    {
        return flatEffects;
    }

    public virtual void ModuleAction() { }
}
