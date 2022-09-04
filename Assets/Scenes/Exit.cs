using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(startExit());
        Debug.LogError("EXIST");
        
    }

    IEnumerator startExit()
    {
        yield return new WaitForSeconds(5f);
        Application.Quit();
    }
}
