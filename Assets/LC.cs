using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LC : MonoBehaviour
{
    public void Lapis_Lazuli(string Bob)
    {
        SceneManager.LoadScene(Bob);
    }
}
