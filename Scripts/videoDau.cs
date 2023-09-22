using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoDau : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(skip());
    }
    public IEnumerator skip()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
