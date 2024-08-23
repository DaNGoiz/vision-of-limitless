using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    private Slider slider;
    public enum SliderType
    {
        ALL,
        BGM,
        BGS,
    }
    public SliderType sliderType;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("ALL"))
        {
            PlayerPrefs.SetFloat("ALL", 1);
        }
        if (!PlayerPrefs.HasKey("BGM"))
        {
            PlayerPrefs.SetFloat("BGM", 1);
        }
        if (!PlayerPrefs.HasKey("BGS"))
        {
            PlayerPrefs.SetFloat("BGS", 1);
        }
    }

    void Start()
    {
        slider = GetComponent<Slider>();

        GetSliderValue(sliderType);
    }

    public void OnSliderValueChanged()
    {
        SetSliderValue(sliderType);
    }

    private void SetSliderValue(SliderType type)
    {
        switch (type)
        {
            case SliderType.ALL:
                PlayerPrefs.SetFloat("ALL", slider.value);
                break;
            case SliderType.BGM:
                PlayerPrefs.SetFloat("BGM", slider.value);
                break;
            case SliderType.BGS:
                PlayerPrefs.SetFloat("BGS", slider.value);
                break;
        }
    }

    private void GetSliderValue(SliderType type)
    {
        switch (type)
        {
            case SliderType.ALL:
                slider.value = PlayerPrefs.GetFloat("ALL");
                Debug.Log("ALL: " + PlayerPrefs.GetFloat("ALL"));
                break;
            case SliderType.BGM:
                slider.value = PlayerPrefs.GetFloat("BGM");
                break;
            case SliderType.BGS:
                slider.value = PlayerPrefs.GetFloat("BGS");
                break;
        }
    }
}
