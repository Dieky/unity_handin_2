using UnityEngine;

public class GunScript : MonoBehaviour
{
    public int damage = 10;
    public float range = 10000f;
    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
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

            Health health = hit.transform.GetComponentInParent<Health>();
            if (health != null)
            {
                health.TakeDamage(damage);
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
