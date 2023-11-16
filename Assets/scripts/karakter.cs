using UnityEngine;

public class karakter : MonoBehaviour
{
    public float hareketHizi = 5f;
    public GameObject mermiPrefab;
    public Transform ateşNoktası;

    void Update()
    {
        HareketKontrol();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AteşEt();
        }
    }

    void HareketKontrol()
    {
        float yatayHareket = Input.GetAxis("Horizontal");
        float dikeyHareket = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatayHareket, dikeyHareket, 0f) * hareketHizi * Time.deltaTime;
        transform.Translate(hareket);
    }

    void AteşEt()
    {
        Instantiate(mermiPrefab, ateşNoktası.position, ateşNoktası.rotation);
    }
}
