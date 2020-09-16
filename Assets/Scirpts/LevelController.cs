using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;
    private static int _nextLevelIndex = 1;

    // Start is called before the first frame update

    private void OnEnable() 
    {
        _enemies = FindObjectsOfType<Enemy>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if (enemy != null)
                return;
        }

        Debug.Log("You Killed All Enemies");
        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;
        // SceneManager.LoadScene(nextLevelName);
        
    }
}
