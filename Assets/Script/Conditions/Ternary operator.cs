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
 // ternary operator : exemple de conditions imbriqu�es
 
    string result = x > y ? "X est plus grand que Y" : x < y ? "X est plus petit que Y" : x == y ? "X est �gal � Y" : "Pas de r�sultat";

 */
