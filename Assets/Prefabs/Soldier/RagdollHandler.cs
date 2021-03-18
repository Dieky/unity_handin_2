using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class RagdollHandler : MonoBehaviour
{

    [SerializeField] private GameObject submachineGun;
    void Start()
    {
        GoRagdoll(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GoRagdoll(true);
        }
    }

    public void GoRagdoll(bool v)
    {
        if (v == true)
        {
            // disable animator
            GetComponent<Animator>().enabled = false;
            GetComponent<MoveToGoal>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            submachineGun.transform.SetParent(null);
            submachineGun.GetComponent<Rigidbody>().useGravity = true;
            submachineGun.GetComponent<Rigidbody>().isKinematic = false;
        }

        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rigidbodies)
        {
            if (rb.gameObject != gameObject)
            {
                rb.useGravity = v;
                rb.isKinematic = !v;
            }
        }
    }
}
