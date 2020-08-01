using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharacter : MonoBehaviour
{
    public void OnDestroy()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
