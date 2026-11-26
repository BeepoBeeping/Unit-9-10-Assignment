using Unity.VisualScripting;
using UnityEngine;


public class RotationScript : MonoBehaviour
{
    Gyroscope gyro;
    private Quaternion baseRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Input.gyro.enabled = true;
        baseRotation = Quaternion.Euler(90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.gyro.enabled) return;

        Quaternion raw = Input.gyro.attitude;
        Quaternion converted = new Quaternion(raw.x, raw.y, -raw.z, -raw.w);

        transform.localRotation = baseRotation * converted;

        gameObject.transform.rotation = converted;

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
