using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    
    void Update()
    {
        if (this.transform.position.y < Camera.main.transform.position.y - 5)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
