using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;
    [SerializeField] public AudioSource audioSource;

    void Start()
    {
        _slider.onValueChanged.AddListener((v) => {
            audioSource.volume = v;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
