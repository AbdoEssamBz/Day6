using UnityEngine;

public class CollisonandTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisonEnter");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisonStay");

    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisonExit");

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(" OnTriggerExit");

    }
}
