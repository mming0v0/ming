using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject projectile;

    public void FireProjectile()
    {
        GameObject temp = (GameObject)Instantiate(projectile);

        temp.transform.position = this.gameObject.transform.position;

        temp.GetComponent<ProjectMove>().launchDirection = transform.forward;

        Destroy(temp, 10.0f);

    }
}
