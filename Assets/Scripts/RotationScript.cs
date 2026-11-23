using Unity.VisualScripting;
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

        if (gameObject.transform.rotation.eulerAngles.y >= 0 || gameObject.transform.rotation.eulerAngles.y <= 0)
        {
            gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, 0, gameObject.transform.eulerAngles.z);
        }

        if (gameObject.transform.rotation.eulerAngles.x >= 0 || gameObject.transform.rotation.eulerAngles.x <= 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, gameObject.transform.eulerAngles.y, gameObject.transform.eulerAngles.z);
        }
    }
}
