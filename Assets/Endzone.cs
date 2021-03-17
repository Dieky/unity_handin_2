using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endzone : MonoBehaviour
{
    // Start is called before the first frame update
    public float chances = 5f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENDZONE REACHED");
        chances -= 1f;
        Debug.Log(chances);
        Destroy(other.gameObject);
    }
    
    // Update is called once per frame
   
}
