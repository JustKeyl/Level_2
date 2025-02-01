using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature player;
    public TextMeshProUGUI degreesText;

    void Update()
    {
        degreesText.text = player.temperatureCurrent.ToString();
    }
}
