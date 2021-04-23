using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update

    public float fwdforce = 1000f;
    public float sidewaysforce = 500f;
    public float upwardforce = 1000f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "trig" )
        {
            HighScore.instance.AddScore();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, fwdforce * Time.deltaTime);
        
        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upwardforce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f )
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
