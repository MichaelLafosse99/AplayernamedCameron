using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float xValue = 0.01f;
    [SerializeField] float yValue = 0.0f;
    [SerializeField] float zValue = 0.0f;

    float xMax = 10.0f;
    float xMin = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(xValue, yValue, zValue);

        if (transform.position.x >= xMax)
        {
            xValue = -0.02f;

        }

        if (transform.position.x <= xMin)
        {

            xValue = 0.0f;
        }

        return;
    }
}
