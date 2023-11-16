using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KarakterCan : MonoBehaviour
{
    public int maxCan = 3;
    private int can;
    public Text canText;

    void Start()
    {
        can = maxCan;
        GuncelleCanUI();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dusman")
        {
            can--;

            GuncelleCanUI();

            if (can <= 0)
            {
                OyunuYenidenBaslat();
            }
        }
    }

    void GuncelleCanUI()
    {
        canText.text = "Can: " + can.ToString();
    }

    void OyunuYenidenBaslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
