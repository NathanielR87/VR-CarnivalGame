using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beerBottle : MonoBehaviour
{
    public List<Rigidbody> allParts = new List<Rigidbody>();

    // Start is called before the first frame update
    public void Shatter()
    {
        foreach (Rigidbody part in allParts)
        {
            part.isKinematic = false;
        }
    }
}

