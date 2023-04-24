using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float waitTime;
    [SerializeField] string nextScenes;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Time());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Time()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(nextScenes);
    }
}
