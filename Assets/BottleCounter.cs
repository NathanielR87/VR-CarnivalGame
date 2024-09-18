using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class BottleCounter : MonoBehaviour
{
    private int bottleCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        BottleEnterScript.BottleEnterEvent += this.BottleIncrement;
    }

    public void BottleIncrement(int amt) {
        bottleCount+=amt;
        GetComponent<TMP_Text>().text = "# Bottles: " + bottleCount;
    }

    void OnDisable() {
        BottleEnterScript.BottleEnterEvent -= this.BottleIncrement;
    }
}
