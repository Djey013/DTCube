using UnityEngine;

public class VECTOR : MonoBehaviour
{
    //Direction
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 5);
    }

}




/*

//syntaxe de base

Vector3 direction = new Vector3(0, 0, 5);

private void Update()
{
    transform.Translate(direction * Time.deltaTime);
}
 
 * */