using UnityEngine;
using UnityEngine.UI;

public class HappyScore : MonoBehaviour
{
    public string objectTag = "Object"; // 여기에 Object의 태그를 지정하세요.
    public Slider slider;

    public int maxSliderValue = 10; // 슬라이더의 최대 값
    public int minSliderValue = 1; // 슬라이더의 최소 값

    private void Start()
    {
        // 시작할 때 슬라이더를 초기화합니다.
        slider.minValue = minSliderValue;
        slider.maxValue = maxSliderValue;
        slider.value = maxSliderValue; // 슬라이더를 최대 값으로 설정합니다.
    }

    private void Update()
    {
        // Object 태그를 가진 모든 물체를 찾습니다.
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(objectTag);

        // 찾은 물체의 수에 따라 슬라이더 값을 조절합니다.
        AdjustSliderValue(objectsWithTag.Length);
    }

    private void AdjustSliderValue(int objectCount)
    {
        // 슬라이더의 값을 조절합니다.
        float sliderValue = Mathf.Lerp(minSliderValue, maxSliderValue, Mathf.InverseLerp(0, maxSliderValue, objectCount));
        slider.value = sliderValue;
    }
}


