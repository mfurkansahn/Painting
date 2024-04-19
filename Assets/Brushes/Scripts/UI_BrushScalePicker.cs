using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_BrushScalePicker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PickerLabel;
    [SerializeField] Slider PickerSlider;
    [SerializeField] float DefaultValue = 0.25f;
    [SerializeField] UnityEvent<float> OnValueChanged = new();

    // Start is called before the first frame update
    void Start()
    {
        SetValue(DefaultValue, true);
    }

    public void OnSliderValueChanged(float InNewValue)
    {
        OnValueChanged.Invoke(InNewValue);
    }

    public void SetValue(float InNewValue, bool InAllowNotifications = true)
    {
        PickerSlider.SetValueWithoutNotify(InNewValue);

        if (InAllowNotifications)
            OnValueChanged.Invoke(InNewValue);
    }
}
