using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMark : MonoBehaviour
{
    public static int quesNum;
    public bool isDone;
    public GameManager gameManager;

    public bool next;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "ques";
        gameManager = GameManager.Instance;
        quesNum++;
        isDone = false;
        next = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDone)
        {
            next = true;
            gameManager.isNext = next;
            Destroy(gameObject);
        }    
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Display question");
        }    
    }
}
