using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    int coin = 0;
    [SerializeField] private TMP_Text CoinCounter;
    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            coin++;
            CoinCounter.text = "Coins : " + coin;
            collectionSound.Play();
        }
    }
}
