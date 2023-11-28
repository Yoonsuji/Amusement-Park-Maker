using UnityEngine;
using UnityEngine.UI;

public class HappyScore : MonoBehaviour
{
    public string objectTag = "Object"; // ���⿡ Object�� �±׸� �����ϼ���.
    public Slider slider;

    public int maxSliderValue = 10; // �����̴��� �ִ� ��
    public int minSliderValue = 1; // �����̴��� �ּ� ��

    private void Start()
    {
        // ������ �� �����̴��� �ʱ�ȭ�մϴ�.
        slider.minValue = minSliderValue;
        slider.maxValue = maxSliderValue;
        slider.value = maxSliderValue; // �����̴��� �ִ� ������ �����մϴ�.
    }

    private void Update()
    {
        // Object �±׸� ���� ��� ��ü�� ã���ϴ�.
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(objectTag);

        // ã�� ��ü�� ���� ���� �����̴� ���� �����մϴ�.
        AdjustSliderValue(objectsWithTag.Length);
    }

    private void AdjustSliderValue(int objectCount)
    {
        // �����̴��� ���� �����մϴ�.
        float sliderValue = Mathf.Lerp(minSliderValue, maxSliderValue, Mathf.InverseLerp(0, maxSliderValue, objectCount));
        slider.value = sliderValue;
    }
}


