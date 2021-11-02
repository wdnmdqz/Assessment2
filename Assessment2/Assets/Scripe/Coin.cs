using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            ScoreKeeper.Instance.AddPointsPerPickP1();
            Destroy(gameObject);
        }
        else if(other.gameObject.layer == 8)
        {
            ScoreKeeper.Instance.AddPointsPerPickP2();
            Destroy(gameObject);
        }
        
    }
}
