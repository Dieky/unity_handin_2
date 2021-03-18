using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Soldier")
        {
            Debug.Log("ENDZONE REACHED");
            //chances -= 1f;
            Debug.Log("Dead");
            Destroy(other.gameObject);
        }
    }
}
