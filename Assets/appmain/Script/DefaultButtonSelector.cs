using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultButtonSelector : MonoBehaviour
{
    [SerializeField]
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
