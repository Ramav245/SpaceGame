using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Money : MonoBehaviour
{
    // Start is called before the first frame update
    private int moneyAmount; 


    [SerializeField]
    private Text coinCounter; 

    void Start()
    {
        moneyAmount = 0;
    }

    void Update()
    {
        coinCounter.text = "Diamonds: " + moneyAmount.ToString();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<CoinScript>())
        {
            moneyAmount += 1; 
            Destroy(other.gameObject);
        }
    }



}
