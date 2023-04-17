using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectMove : MonoBehaviour
{
    public Vector3 launchDirection;
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "wall1")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;

        transform.Translate(launchDirection * moveAmount);
    }

}