using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoMan2 : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(skip());
    }
    public IEnumerator skip()
    {
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }
}
