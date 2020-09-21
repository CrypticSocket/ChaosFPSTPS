using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 10f;
    public float lifeSpan = 2f;

    private float lifeDurationChecker;
    // Start is called before the first frame update
    void OnEnable()
    {
        lifeDurationChecker = lifeSpan;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        lifeDurationChecker -= Time.deltaTime;
        if(lifeDurationChecker <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
