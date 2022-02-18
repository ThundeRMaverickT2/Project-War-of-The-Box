using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileScript : MonoBehaviour
{
    [SerializeField] private Transform TargetHit;
    [SerializeField] private Transform NoTargetHit;
    [SerializeField] private float speed = 10f;
    
    private Rigidbody bulletRigidbody;
    

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        bulletRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<TargetObject>() != null)
        {
            Instantiate(TargetHit, transform.position, Quaternion.identity);
        }
        else 
        {
            Instantiate(NoTargetHit, transform.position, Quaternion.identity);
        }
        {
            Destroy(gameObject);    
        }
    }
}
