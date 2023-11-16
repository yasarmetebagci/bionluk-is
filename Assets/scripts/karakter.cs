using UnityEngine;

public class karakter : MonoBehaviour
{
    public float hareketHizi = 5f;
    public GameObject mermiPrefab;
    public Transform ate�Noktas�;

    void Update()
    {
        HareketKontrol();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ate�Et();
        }
    }

    void HareketKontrol()
    {
        float yatayHareket = Input.GetAxis("Horizontal");
        float dikeyHareket = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatayHareket, dikeyHareket, 0f) * hareketHizi * Time.deltaTime;
        transform.Translate(hareket);
    }

    void Ate�Et()
    {
        Instantiate(mermiPrefab, ate�Noktas�.position, ate�Noktas�.rotation);
    }
}
