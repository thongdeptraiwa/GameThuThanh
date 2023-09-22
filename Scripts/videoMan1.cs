using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoMan1 : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(skip());
    }
    public IEnumerator skip()
    {
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
}
