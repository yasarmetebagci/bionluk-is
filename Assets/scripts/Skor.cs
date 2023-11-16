using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public Text skorText;
    public float skorArtisSuresi = 1f;
    private float zamanGecenArtis = 0f;
    private int skor = 0;

    void Update()
    {
        ZamanGecenArtisKontrol();

        // Skoru ekranda göster
        skorText.text = "Skor: " + skor.ToString();
    }

    void ZamanGecenArtisKontrol()
    {
        zamanGecenArtis += Time.deltaTime;

        if (zamanGecenArtis >= skorArtisSuresi)
        {
            SkorArttir();
            zamanGecenArtis = 0f;
        }
    }

    void SkorArttir()
    {
        skor++;
    }
}
