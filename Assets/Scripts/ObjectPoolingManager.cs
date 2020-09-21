using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{

    private static ObjectPoolingManager instance;
    public GameObject bulletPrefab;
    public int bulletCapacity = 20;
    public List<GameObject> bulletList;
    public static ObjectPoolingManager Instance
    {
        get
        {
            return instance;
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        bulletList = new List<GameObject>(bulletCapacity);
        for(int i=0; i<bulletCapacity; i++)
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.SetParent(transform);
            bulletObject.SetActive(false);

            bulletList.Add(bulletObject);
        }
    }

    // Update is called once per frame
    public GameObject GetBullet()
    {
        foreach (GameObject bullet in bulletList)
        {
            if(!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }

        GameObject bulletObject = Instantiate(bulletPrefab);
        bulletObject.transform.SetParent(transform);
        bulletList.Add(bulletObject);
        return bulletObject;

    }
}
