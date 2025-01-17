using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D Rigidbody;
    bool isJumping;
    public float jumpForce;
    public float gravite;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Physics.gravity = new Vector3(0, -gravite, 0);  // Définir la gravité pour la descente rapide

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Jump");
            isJumping = true;
        }
    }

    private void FixedUpdate() {
        if (isJumping)
        {
            Rigidbody.linearVelocity = new Vector2(Rigidbody.linearVelocity.x, jumpForce); // Réinitialise la vitesse verticale
            Rigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = false;
        }
    }
}
