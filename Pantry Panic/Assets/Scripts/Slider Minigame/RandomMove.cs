using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomMove : MonoBehaviour
{
    public int xBounds;
    private void OnEnable()
    {
        transform.position = new Vector3(Random.Range(-xBounds, xBounds), transform.position.y, transform.position.z);
    }
}
