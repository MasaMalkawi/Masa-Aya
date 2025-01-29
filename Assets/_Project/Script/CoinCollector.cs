using UnityEngine;
using TMPro; // لاستيراد مكتبة TextMeshPro

public class CoinCollector : MonoBehaviour
{
    public int coins = 0; // عدد العملات
    public TextMeshProUGUI coinText; // عنصر UI لإظهار العدد

    void Start()
    {
        UpdateCoinUI(); // تحديث النص عند بدء اللعبة
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // التحقق من لمس العملة
        {
            coins++; // زيادة عدد العملات
            UpdateCoinUI(); // تحديث النص في الواجهة
            Destroy(other.gameObject); // حذف العملة من المشهد
        }
    }

    void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coins; // تحديث عدد العملات في النص
    }
}
