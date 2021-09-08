using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeoutObject : MonoBehaviour
{
    public float lifeSpan;
    public float age;

	private void Update()
    {
        age += Time.deltaTime;
        if (age >= lifeSpan)
            Destroy(gameObject);

        transform.Rotate(Vector3.up, Time.deltaTime * 60f);
    }
}
