using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGame : MonoBehaviour
{
    public void ToGameFunction() {
        SceneManager.LoadScene("__Scene_0");
    }
}
