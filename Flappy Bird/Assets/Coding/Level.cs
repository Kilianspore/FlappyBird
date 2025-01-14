using UnityEngine;

public class Level : MonoBehaviour
{
    public float Speed;      
    public float Deadzone; 
    Vector3 initPosition;
    public float ecartFixe; 

    void Start()
    {
        initPosition = transform.position;
    }

    void Update()
    {
        transform.position += new Vector3(-Speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x < Deadzone)
        {
            if (gameObject.name == "Tuyau_bas" || gameObject.name == "Tuyau_haut")
            {
                float newPosTuyauBasY, newPosTuyauHautY;

                newPosTuyauBasY = Random.Range(-5.39f, -3f);

                newPosTuyauHautY = newPosTuyauBasY + ecartFixe;

                if (newPosTuyauHautY > 3.34f)
                {
                    newPosTuyauHautY = 3.34f; 
                    newPosTuyauBasY = newPosTuyauHautY - ecartFixe;
                }

                GameObject.Find("Tuyau_bas").transform.position = new Vector3(10f, newPosTuyauBasY, 0f);
                GameObject.Find("Tuyau_haut").transform.position = new Vector3(10f, newPosTuyauHautY, 0f);

                Debug.Log($"Position Tuyau Bas: {newPosTuyauBasY}, Tuyau Haut: {newPosTuyauHautY}, Ecart: {ecartFixe}");
            }
            else
            {
                transform.position = initPosition;
            }
        }
    }
}
