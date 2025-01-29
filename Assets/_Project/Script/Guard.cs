using UnityEngine;

public class Guard : MonoBehaviour
{
    public int requiredCoins = 15; // عدد العملات المطلوبة لفتح الباب
    public GameObject door; // الباب الذي سيتم فتحه

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // التحقق من أن اللاعب هو من لمس الحارس
        {
            CoinCollector playerCoins = other.GetComponent<CoinCollector>();

            if (playerCoins != null && playerCoins.coins >= requiredCoins)
            {
                playerCoins.coins -= requiredCoins; // خصم العملات المطلوبة
                door.SetActive(false); // تعطيل الباب (يتم فتحه)
                Debug.Log("The door is open! You rescued the princess!");
            }
            else
            {
                Debug.Log("Not enough coins! You need " + (requiredCoins - playerCoins.coins) + " more.");
            }
        }
    }
}
