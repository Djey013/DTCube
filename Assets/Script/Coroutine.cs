using UnityEngine;
using System.Collections;

public class Coroutines : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }


    IEnumerator MyCoroutine()
    {
        print("MyCoroutine commence son exécution.");
        yield return new WaitForSeconds(5);
        print("MyCoroutine a terminé son exécution.");
    }

}
