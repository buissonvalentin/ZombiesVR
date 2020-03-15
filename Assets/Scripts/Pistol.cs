using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pistol : MonoBehaviour
{
    public Transform barelEndTransform;
    public GameObject bulletGO;
    public int bulletSpeed;
    Vector3 pistolRotation;
    // Start is called before the first frame update
    void Start()
    {
        pistolRotation = (gameObject.GetComponentInParent(typeof(Transform)) as Transform).rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pistolRotation = (gameObject.GetComponentInParent(typeof(Transform)) as Transform).rotation.eulerAngles;
            GameObject bulletInstance = Instantiate(bulletGO, barelEndTransform.position, Quaternion.Euler(pistolRotation));
            Rigidbody bulletInstanceRigidbody = bulletInstance.GetComponent<Rigidbody>();
            bulletInstanceRigidbody.velocity = barelEndTransform.forward * bulletSpeed;
        }
    }
}

