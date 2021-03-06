using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{

    public Sprite flagClosed;
    public Sprite flagOpen;

    private SpriteRenderer theSpriteRenderer;

    public bool checkpointActive;

    // Start is called before the first frame update
    void Start()
    {
        theSpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") //플레이어와 닿으면
        {
            // 깃발이 펴진다.
            theSpriteRenderer.sprite = flagOpen;
            checkpointActive = true;
        }
    }


}
