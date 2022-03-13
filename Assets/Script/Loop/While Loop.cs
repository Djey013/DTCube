using UnityEngine;

public class WhileLoop : MonoBehaviour


//While Loop
{ 
    int cupsInTheSink = 4;

    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }

}


