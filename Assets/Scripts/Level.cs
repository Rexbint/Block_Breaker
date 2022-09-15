using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //params
    public int breakableBlocks;

    //cashed references
    SceneLoader sceneLoader;
    // Start is called before the first frame update
    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {

        breakableBlocks--;
        if (breakableBlocks<=0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
