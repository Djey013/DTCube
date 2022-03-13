using UnityEngine;

public class Conditions : MonoBehaviour
{
    public int x = 20;
    public int y = 10;

    //ternary operator
    void Start()
    {
        string result = x > y ? "X est plus grand que Y" : "X est plus petit que Y";
        Debug.Log(result);
    }

}

/*
 // ternary operator : exemple de conditions imbriquées
 
    string result = x > y ? "X est plus grand que Y" : x < y ? "X est plus petit que Y" : x == y ? "X est égal à Y" : "Pas de résultat";

 */
