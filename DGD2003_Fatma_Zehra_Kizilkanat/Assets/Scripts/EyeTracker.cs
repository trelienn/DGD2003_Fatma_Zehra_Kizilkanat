using UnityEngine;

public class EyeTracker : MonoBehaviour
{
    public float donmeHizi = 5f;
    private Camera anaCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // oyun basladiginda kamerayi bulup hafizaya aliyoruz
        // boylece update icinde her saniye 60 kere kamerayi aratip pc yi yormuyoruz optimizasyn yanee
        anaCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // farenin ekrandaki xy konumunu aliyoruz
        //ama ahvada durmasi icin oan kameradan ileriye dogru bir derinlik (z) veriyoruz
        Vector3 fareEkranda = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15f);

        // ekranda duran bu noiktayi, 3 boyutl oyun dunyasina havada ucan gercek hedefe ceviriyoruz
        Vector3 targetPoint = anaCamera.ScreenToWorldPoint(fareEkranda);
        //Hedef nokta eksi bulunduðumuz nokta = Bakýþ Yönü
        Vector3 bakisYonu = targetPoint - transform.position;
        // yumusak donuz (slepr) gozun hedefe suzulerek donmesi
        Quaternion hedefRotasyon = Quaternion.LookRotation(bakisYonu);
        transform.rotation = Quaternion.Slerp(transform.rotation, hedefRotasyon, Time.deltaTime * donmeHizi);
    }
}
