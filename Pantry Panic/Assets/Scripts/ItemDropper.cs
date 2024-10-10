using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemDropper : MonoBehaviour
{
    public List<GameObject> Ingredients;
    public float spawnHeight;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dropper());
    }

    IEnumerator Dropper()
    {
        bool stop = false;
        yield return new WaitForSeconds(Random.Range(0.1f,0.3f));
        while(!stop)
        {
            Instantiate(Ingredients[Random.Range(0, Ingredients.Count)], new Vector3(Random.Range(-3f, 3f), spawnHeight, 0), new Quaternion(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f)));
            yield return new WaitForSeconds(Random.Range(0.1f, 0.3f));
        }
    }
}
