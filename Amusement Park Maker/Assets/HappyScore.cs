using UnityEngine;
using UnityEngine.UI;

public class HappyScore : MonoBehaviour
{
    public string objectTag = "Object";
    public Slider slider;

    public int maxSliderValue = 100; // 슬라이더의 최대 값
    public int minSliderValue = 1; // 슬라이더의 최소 값

    private void Start()
    {
        slider.minValue = minSliderValue;
        slider.maxValue = maxSliderValue;
        slider.value = maxSliderValue;
    }

    private void Update()
    {
        // Object 태그를 가진 모든 물체
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(objectTag);

        AdjustSliderValue(objectsWithTag.Length);
    }

    private void AdjustSliderValue(int objectCount)
    {
        float sliderValue = Mathf.Lerp(minSliderValue, maxSliderValue, Mathf.InverseLerp(0, maxSliderValue, objectCount));
        slider.value = sliderValue;
    }
}


