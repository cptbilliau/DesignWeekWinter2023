using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    private Button heatButton;

    private void Awake()
    {
        heatButton = GetComponent<Button>();
        heatButton.onClick.AddListener(heatButtonClick);
    }

    void heatButtonClick()
    {
        Debug.Log("Heat Button Pressed");
    }
}
