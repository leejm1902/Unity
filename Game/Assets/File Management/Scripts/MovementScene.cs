using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MovementScene : MonoBehaviour
{
    public void NextScene(int select)
    {
        SelectManager.action();
        SceneManager.LoadScene(select);
    }
    
}
