using UnityEngine;


public class RotationScript : MonoBehaviour
{
    Gyroscope gyro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gyro = Input.gyro;
        if (!gyro.enabled)
        {
            gyro.enabled = true;
        }


    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.rotation = gyro.attitude;
    }
}
