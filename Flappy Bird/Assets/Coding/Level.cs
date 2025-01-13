using UnityEngine;

public class Level : MonoBehaviour
{

    public float Speed = 10f;

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(-Speed * Time.deltaTime, 0f);
        
    }
}
