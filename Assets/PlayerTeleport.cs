using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    [SerializeField] private LayerMask tpLayer;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            RaycastHit tpHit;
            bool hitFound = Physics.Raycast(transform.position, Camera.main.transform.forward, out tpHit, Mathf.Infinity, tpLayer);
            if (hitFound)
            {
                transform.position = new Vector3(tpHit.point.x, transform.position.y, tpHit.point.z);
            }
        }
    }
}