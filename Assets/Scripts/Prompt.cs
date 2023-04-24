using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(TextMeshPro))]
public class Prompt : MonoBehaviour
{
    [SerializeField] string[] texts;
    [SerializeField] float waitTime = 3;
    [SerializeField] string nextScenes = null;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeManager());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeText(string text)
    {
        GetComponent<TextMeshPro>().text = text;
    }
    public IEnumerator TimeManager()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            ChangeText(texts[i]);
            yield return new WaitForSeconds(waitTime);
        }
        if (! string.IsNullOrWhiteSpace(nextScenes))
        {
            SceneManager.LoadScene(nextScenes);
        }
    }   
}
