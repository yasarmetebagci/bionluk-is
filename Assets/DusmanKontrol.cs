using UnityEngine;

public class DusmanKontrol : MonoBehaviour
{
    public float dusmanHizi = 3f;
    public int temasSayisiLimiti = 2;
    private int temasSayisi = 0;
    private Transform karakterTransform;

    void Start()
    {
        karakterTransform = GameObject.FindGameObjectWithTag("Karakter").transform;
    }

    void Update()
    {
        TakipEtKarakter();

        if (temasSayisi >= temasSayisiLimiti)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mermi")
        {
            Destroy(other.gameObject);
            temasSayisi++;
        }
    }

    void TakipEtKarakter()
    {
        transform.position = Vector2.MoveTowards(transform.position, karakterTransform.position, dusmanHizi * Time.deltaTime);
    }
}
