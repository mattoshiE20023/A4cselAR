using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class updateLocationText : MonoBehaviour
{
    public TextMeshPro location_text;

    // Update is called once per frame
    void Update()
    {
        location_text.text = $"lat:{Location.Instance.latitude}\nlon:{Location.Instance.longitude}\nhgt:{Location.Instance.altitude}";
        
    }
}
