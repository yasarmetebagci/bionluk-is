using UnityEngine;

public class MermiKontrol : MonoBehaviour
{
    public float mermiHizi = 10f;
    public float mermiOmur = 5f;

    void Start()
    {
        Destroy(gameObject, mermiOmur);
    }

    void Update()
    {
        transform.Translate(Vector3.right * mermiHizi * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dusman")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

