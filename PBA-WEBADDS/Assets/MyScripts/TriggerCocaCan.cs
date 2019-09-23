using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCocaCan : MonoBehaviour
{
    public GameObject platform;
    public GameObject can;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        platform.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        platform.SetActive(true);
        text.text = "Cool now find the platform for this add and stand on it. Is's a red platform, somewhere around here";
        Object.Destroy(can);
    }
}
