using UnityEngine;

public class RigidScript : MonoBehaviour

{
    public float force = 10f;
    private Rigidbody Rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("Space Pressed");

            Rb.AddForce(0, 0, force);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space released");
            Rb.AddForce(0, 0, -force);
            
        }
    }
}
