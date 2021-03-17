using UnityEngine;

public class Endzone : MonoBehaviour
{
    public float chances = 5f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENDZONE REACHED");
        chances -= 1f;
        Debug.Log(chances);
        Destroy(other.gameObject);
    }
}
