using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    public Slider sliderValue;
    public Text sliderText;
    
    public void SliderTextChange()
    {
        sliderText.text = "Slider Value: " + sliderValue.value.ToString();
    }
}
