//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerShoot : MonoBehaviour
//{
//    [SerializeField] private GameObject bulletPrefab;
//    [SerializeField] private float bulletForce = 500f;
//    [SerializeField] private Vector3 bulletOffset;

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            GameObject newBullet = Instantiate(bulletPrefab, Camera.main.transform);
//            newBullet.transform.position += bulletOffset;
//            newBullet.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * bulletForce);
//        }
//    }
//}




//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI; // Add this for UI

//public class PlayerShoot : MonoBehaviour
//{
//    [SerializeField] private GameObject bulletPrefab;
//    [SerializeField] private float bulletForce = 500f;
//    [SerializeField] private Vector3 bulletOffset;
//    [SerializeField] private Text ballsLeftText; // Reference to UI text
//    private int ballsLeft = 4; // Initial number of balls

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0) && ballsLeft > 0)
//        {
//            GameObject newBullet = Instantiate(bulletPrefab, Camera.main.transform);
//            newBullet.transform.position += bulletOffset;
//            newBullet.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * bulletForce);

//            ballsLeft--; // Decrease the number of balls
//        }
//    }
//}



using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletForce = 500f;
    [SerializeField] private Vector3 bulletOffset;
    [SerializeField] private TextMeshProUGUI ballsLeftText;

    //[SerializeField] private TMPro.TextMeshProUGUI ballsLeftText;

    //[SerializeField] private Text ballsLeftText; // Reference to UI text
    private int ballsLeft = 4; // Initial number of balls

    // Start is called before the first frame update
    void Start()
    {
        UpdateBallsLeftText(); // Initialize the UI text
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ballsLeft > 0)
        {
            GameObject newBullet = Instantiate(bulletPrefab, Camera.main.transform);
            newBullet.transform.position += bulletOffset;
            newBullet.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * bulletForce);

            ballsLeft--; // Decrease the number of balls
            UpdateBallsLeftText(); // Update the UI text
        }
    }

    // Function to update the UI text
    void UpdateBallsLeftText()
    {
        ballsLeftText.text = "Balls Left: " + ballsLeft.ToString();
    }
}
