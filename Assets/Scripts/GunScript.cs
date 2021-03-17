using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 10000f;
    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.ScreenPointToRay(Input.mousePosition), out hit, range))
        {

            Debug.Log(hit.transform.name);
            DealDamage combat = hit.transform.GetComponent<DealDamage>();
            if(combat != null)
            {
                combat.takeDamage(damage);
            }
        }
    }

    void OnDrawGizmos()
{   
    // Gizmos.color = Color.red;
    // Vector3 direction = fpsCam.transform.forward * range;
    // Gizmos.DrawRay(transform.position, direction);
}
}
