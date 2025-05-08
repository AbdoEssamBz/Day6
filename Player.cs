using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float Speed ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void MoveUp(InputAction.CallbackContext con)
    {
        if (con.started) { 
        transform.Translate(new Vector3(0, 0, Speed*Time.deltaTime));
            Debug.Log("Button Pressed");
        }
        if (con.canceled)
        {
            Debug.Log("Button released");
         //   transform.Translate(new Vector3(0, 0, Speed * Time.deltaTime));
        }
    }
    public void MoveDown()
    {
        transform.Translate(new Vector3(0, 0, -Speed));


    }
    public void MoveRight()
    {

        transform.Translate(new Vector3(Speed, 0, 0));
    }
    public void Moveleft()
    {

        transform.Translate(new Vector3(-Speed, 0, 0));
    }
}
