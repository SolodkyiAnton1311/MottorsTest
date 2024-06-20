
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float distance;
    public float xSpeed;
    public float ySpeed;
    public float scrollSpeed;

    private float x = 0.0f;
    private float y = 0.0f;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
        xSpeed = 120.0f;
        ySpeed = 120.0f;
        scrollSpeed = 10.0f;
        distance = 20f;
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            distance -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
            distance = Mathf.Clamp(distance, 2.0f, 15.0f);

            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
     
    }
}