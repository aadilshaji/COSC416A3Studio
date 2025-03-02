using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    private int coinsCollected = 0;
    public TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinsCollected++;
            coinText.text = "Coins: " + coinsCollected;
            Debug.Log("Coins: " + coinsCollected);
            Destroy(other.gameObject);
        }
    }
}
