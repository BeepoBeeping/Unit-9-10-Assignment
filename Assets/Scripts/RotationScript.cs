using Unity.VisualScripting;
using UnityEngine;


public class RotationScript : MonoBehaviour
{
    Gyroscope gyro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.rotation = Input.gyro.attitude;

        if (gameObject.transform.rotation.eulerAngles.z >= 90 || gameObject.transform.rotation.eulerAngles.z <= -90)
        {
            gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, 0);
        }

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
