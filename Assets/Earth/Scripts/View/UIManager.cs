using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    private static string DEFAULT_VALUE = "Click on earth";

    [SerializeField] private Text text;

    [SerializeField] private Image image;

    [SerializeField] private Sprite sun;

    [SerializeField]
    private Sprite fewClouds;

    [SerializeField]
    private Sprite scatteredClouds;

    [SerializeField]
    private Sprite brokenClouds;

    [SerializeField]
    private Sprite showerRain;

    [SerializeField]
    private Sprite rain;

    [SerializeField]
    private Sprite thunderStorm;

    [SerializeField]
    private Sprite snow;

    [SerializeField]
    private Sprite mist;


    public void UpdateUI(WeatherData data)
    {
        if (data != null)
        {
            text.text = data.City;
            UpdateImage(data.Weather);
        } else
        {
            text.text = DEFAULT_VALUE;
            image.sprite = null;
        }
    }

    private void UpdateImage(string pWeather)
    {
        switch (pWeather)
        {
            case "clear sky":
                image.sprite = sun;
                break;
            case "few clouds":
                image.sprite = fewClouds;
                break;
            case "scattered clouds":
                image.sprite = scatteredClouds;
                break;
            case "broken clouds":
                image.sprite = brokenClouds;
                break;
            case "shower rain":
                image.sprite = showerRain;
                break;
            case "rain":
                image.sprite = rain;
                break;
            case "thunderstorm":
                image.sprite = thunderStorm;
                break;
            case "snow":
                image.sprite = snow;
                break;
            case "mist":
                image.sprite = mist;
                break;
        }
    }
}
