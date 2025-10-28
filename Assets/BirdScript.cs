using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float FlapStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            MyRigidBody.linearVelocity = Vector2.up * FlapStrength;
        }
        transform.Rotate(new Vector3(15, 20, 90));
    }
}
