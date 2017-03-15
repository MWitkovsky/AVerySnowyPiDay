using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeHandler : MonoBehaviour {

    private float vxMin = 1.0f, vxMax = 5.0f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.right * Random.Range(vxMin, vxMax);
    }

	private void OnCollisionEnter2D()
    {
        if(Random.Range(0.0f, 100.0f) > 70.0f && transform.position.x < 5.4f)
        {
            Destroy(GetComponent<Rigidbody2D>());
            gameObject.layer = LayerMask.NameToLayer("IdleSnowflake");
        }
    }
}
