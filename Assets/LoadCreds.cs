using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadCreds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadSceneAfterDelay(60));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator loadSceneAfterDelay(float waitbySecs)
    {

        yield return new WaitForSeconds(waitbySecs);
        SceneManager.LoadScene("CreditScene");
    }
}
