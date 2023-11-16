using UnityEngine;

public class DusmanHareket: MonoBehaviour
{
    public float dusmanHizi = 3f;
    private Transform karakterTransform;

    void Start()
    {
        karakterTransform = GameObject.FindGameObjectWithTag("Karakter").transform;
    }

    void Update()
    {
        TakipEtKarakter();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mermi")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void TakipEtKarakter()
    {
        transform.position = Vector2.MoveTowards(transform.position, karakterTransform.position, dusmanHizi * Time.deltaTime);
    }
}
