using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMove : MonoBehaviour
{
    public float speed;
    public float xBounds;

    private Vector3 direction;
    // Start is called before the first frame update
    private void Start()
    {
        direction  = Vector3.right;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x <= -xBounds)
        {
            direction = Vector3.right;
        }
        else if (transform.position.x >= xBounds)
        {
            direction = Vector3.left;
        }
    }
}
