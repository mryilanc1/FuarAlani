using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewController : MonoBehaviour
{
    public TextMeshProUGUI contentText; // ScrollView içindeki uzun metin
    public float scrollSpeed; // Kaydırma hızı

    private ScrollRect scrollView; // ScrollView bileşeni
    public bool isScrolling; // ScrollView'in kaydırılıp kaydırılmadığını belirten bir değer
    private float scrollPosition; // ScrollView'in şu anki konumu
    private float contentHeight; // ScrollView içeriğinin toplam yüksekliği
    private float scrollViewHeight; // ScrollView bileşeninin yüksekliği

    void Start()
    {
        // ScrollView bileşenini al
        scrollView = GetComponent<ScrollRect>();

        // ScrollView içeriğinin yüksekliğini ve bileşeninin yüksekliğini al
        contentHeight = contentText.preferredHeight;
        scrollViewHeight = scrollView.viewport.rect.height;

        // ScrollView'in şu anki konumunu başlangıçta 0 olarak ayarla
        scrollPosition = 0f;

        // ScrollView'in kaydırılmadığını başlangıçta belirt
    }

    void Update()
    {
        // Eğer ScrollView kaydırılıyorsa
        if (isScrolling)
        {
            // ScrollView'in şu anki konumunu güncelle
            scrollPosition += scrollSpeed * Time.deltaTime;

            // ScrollView'in konumunu sınırla
            if (scrollPosition > contentHeight - scrollViewHeight)
            {
                scrollPosition = contentHeight - scrollViewHeight;
            }

            // ScrollView'in konumunu güncelle
            scrollView.verticalNormalizedPosition = 1 - (scrollPosition / (contentHeight - scrollViewHeight));
        }
    }

    public void StartScrolling()
    {
        // ScrollView kaydırmayı başlat
        isScrolling = true;
    }

    public void StopScrolling()
    {
        // ScrollView kaydırmayı durdur
        isScrolling = false;
    }
}