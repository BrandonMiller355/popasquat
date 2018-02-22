using UnityEngine;

public class WallMovement : MonoBehaviour {
    public Rigidbody rbWall;
    public float incomingForce = -500f;
    public float incomingSpeed = -2f;

    public WallMovement wallMovement;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rbWall.AddForce(0, 0, incomingForce * Time.deltaTime);
        rbWall.transform.Translate(Vector3.left * incomingSpeed * Time.deltaTime);
    }
}
