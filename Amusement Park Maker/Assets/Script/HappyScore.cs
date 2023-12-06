using UnityEngine;
using UnityEngine.UI;

public class HappyScore : MonoBehaviour
{
    public string objectTag = "Object";
    public Slider slider;

    public int maxSliderValue = 100; // �����̴��� �ִ� ��
    public int minSliderValue = 1; // �����̴��� �ּ� ��

    private void Start()
    {
        slider.minValue = minSliderValue;
        slider.maxValue = maxSliderValue;
        slider.value = maxSliderValue;
    }

    private void Update()
    {
        // Object �±׸� ���� ��� ��ü
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(objectTag);

        AdjustSliderValue(objectsWithTag.Length);
    }

    private void AdjustSliderValue(int objectCount)
    {
        float sliderValue = Mathf.Lerp(minSliderValue, maxSliderValue, Mathf.InverseLerp(0, maxSliderValue, objectCount));
        slider.value = sliderValue;
    }
}


