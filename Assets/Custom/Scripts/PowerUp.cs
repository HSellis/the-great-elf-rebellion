using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Transform rotatingPartTrans;

    public float rotationSpeed = 50f; // Speed of rotation
    public float floatSpeed = 2f;     // Speed of floating up and down
    public float floatHeight = 0.5f;  // How high/low the object floats
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = rotatingPartTrans.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the Y-axis
        RotateObject();

        // Move the object up and down smoothly
        FloatObject();
    }

    void RotateObject()
    {
        // Rotate the object based on rotation speed and time
        rotatingPartTrans.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void FloatObject()
    {
        // Create a smooth up and down motion using a sine wave
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        rotatingPartTrans.localPosition = new Vector3(rotatingPartTrans.localPosition.x, newY, rotatingPartTrans.localPosition.z);
    }
}
