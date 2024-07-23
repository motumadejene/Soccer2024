using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Country
{
    public string countryName;
    public Sprite flag;
    public Texture playerTexture;
    public Texture hdPlayerTexture;
}

[CreateAssetMenu(fileName = "CountryData", menuName = "ScriptableObjects/CountryData", order = 1)]
public class CountryData : ScriptableObject
{
    public List<Country> countries = new List<Country>();

    public void AddCountry(Country country)
    {
        if (!countries.Exists(c => c.countryName == country.countryName))
        {
            countries.Add(country);
        }
    }

    public void RemoveCountry(string countryName)
    {
        countries.RemoveAll(c => c.countryName == countryName);
    }

    public Country GetCountry(string countryName)
    {
        return countries.Find(c => c.countryName == countryName);
    }

    public bool ContainsCountry(string countryName)
    {
        return countries.Exists(c => c.countryName == countryName);
    }
}
