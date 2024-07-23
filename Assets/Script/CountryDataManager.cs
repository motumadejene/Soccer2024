using UnityEngine;

public class CountryDataManager : MonoBehaviour
{
    public CountryData countryData;

    private void Awake()
    {
        if (countryData == null)
        {
            Debug.LogError("CountryData ScriptableObject is not assigned.");
        }
    }

    public void AddCountry(string countryName, Sprite flag, Texture playerTexture, Texture hdPlayerTexture)
    {
        Country newCountry = new Country
        {
            countryName = countryName,
            flag = flag,
            playerTexture = playerTexture,
            hdPlayerTexture = hdPlayerTexture
        };

        countryData.AddCountry(newCountry);
    }

    public void RemoveCountry(string countryName)
    {
        countryData.RemoveCountry(countryName);
    }

    public Country GetCountry(string countryName)
    {
        return countryData.GetCountry(countryName);
    }

    public bool ContainsCountry(string countryName)
    {
        return countryData.ContainsCountry(countryName);
    }
}
