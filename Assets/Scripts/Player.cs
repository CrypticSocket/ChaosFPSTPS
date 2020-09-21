using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject playerCam;
    public int ammo = 10;
    private int ammoRemaining;

    public int AmmoRemaining
    {
        get
        {
            return ammoRemaining;
        }
    }

    private void Start()
    {
        ammoRemaining = ammo;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(ammoRemaining > 0)
            {
                ammoRemaining--;
                GameObject bulletObject = ObjectPoolingManager.Instance.GetBullet();
                bulletObject.transform.position = playerCam.transform.position + playerCam.transform.forward;
                bulletObject.transform.forward = playerCam.transform.forward;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ammoRemaining = 10;
            Debug.Log("R is pressed");
        }
    }
}
