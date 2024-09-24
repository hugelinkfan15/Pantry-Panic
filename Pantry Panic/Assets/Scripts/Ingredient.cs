using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;
using UnityEngine.UI;
public class Ingredient : MonoBehaviour
{
    static private Dictionary<char, KeyCode> keyCodes = new Dictionary<char, KeyCode>  {
        { 'A', KeyCode.A },
        { 'B', KeyCode.B },
        { 'C', KeyCode.C },
        { 'D', KeyCode.D },
        { 'E', KeyCode.E },
        { 'F', KeyCode.F },
        { 'G', KeyCode.G },
        { 'H', KeyCode.H },
        { 'I', KeyCode.I },
        { 'J', KeyCode.J },
        { 'K', KeyCode.K },
        { 'L', KeyCode.L },
        { 'M', KeyCode.M },
        { 'N', KeyCode.N },
        { 'O', KeyCode.O },
        { 'P', KeyCode.P },
        { 'Q', KeyCode.Q },
        { 'R', KeyCode.R },
        { 'S', KeyCode.S },
        { 'T', KeyCode.T },
        { 'U', KeyCode.U },
        { 'V', KeyCode.V },
        { 'W', KeyCode.W },
        { 'X', KeyCode.X },
        { 'Y', KeyCode.Y },
        { 'Z', KeyCode.Z } };

    public char assigned;
    public static Vector3 sandwhichPoint;
    public RawImage correct;
    public RecipeHolder holder;


    // Start is called before the first frame update
    void Start()
    {
        sandwhichPoint = GameObject.FindGameObjectWithTag("Sandwhich").transform.position;
        holder =  GameObject.FindGameObjectWithTag("Recipe").GetComponent<RecipeHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCodes[assigned]))
        {
            correct.gameObject.SetActive(true);
            transform.position = sandwhichPoint;
            sandwhichPoint.y += gameObject.transform.localScale.y;
        }
    }
}
