using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    private LevelManager theLevelManager;

    public int damageToGive;

    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D others)
    {
        if(others.tag == "Player")
        {
            //theLevelManager.Respawn();

            theLevelManager.HurtPlayer(damageToGive);
        }
    }

}
