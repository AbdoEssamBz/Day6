using UnityEngine;

public class RayCast : MonoBehaviour
{
    Ray ray;
    [SerializeField] Transform ObjectTransform;
    [SerializeField] float MaxDistance =100f;
    [SerializeField] LayerMask layermask;

    void checkCollider() {
        ray = new Ray(ObjectTransform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit,MaxDistance,layermask))
        {
            Debug.Log("Hit"+hit.collider.gameObject.name);
        }
    
    
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkCollider();
    }
}



// Ray Emission
/*
   Ray ray;
    [SerializeField] Transform ObjectTransform;
    [SerializeField] float MaxDistance =100f;
    [SerializeField] LayerMask layermask;

    void checkCollider() {
        ray = new Ray(ObjectTransform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit,MaxDistance,layermask))
        {
            Debug.Log("Hit"+hit.collider.gameObject.name);
        }
    
    
    }
 */