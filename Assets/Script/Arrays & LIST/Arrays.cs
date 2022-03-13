using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] monArray;

    void Start()
    {
        monArray = GameObject.FindGameObjectsWithTag("Ennemis");

        for (int i = 0; i < monArray.Length; i++)
        {
           Debug.Log("Désactivation de l'ennemi " + i);
           monArray[i].SetActive(false);
        }
        

    }

}
