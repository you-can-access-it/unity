using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadScene()
    {
       SceneManager.LoadScene("1");        
    }
 public void LoadSceneAdd()
 {
    SceneManager.LoadScene("1",LoadSceneMode.Additive);
 }
public void UnloadScene(){
    SceneManager.UnloadSceneAsync("1");
}
public void StartLoading()
{
    StartCoroutine(LoadAsync());
}
IEnumerator LoadAsync()
{
    AsyncOperation operation = 
    SceneManager.LoadSceneAsync("1");
    
    while(!operation.isDone)
    {
        Debug.Log("Loading : " +(operation.progress * 100)+ "%");
        yield return null;
        
    }
}
}

