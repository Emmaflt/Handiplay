using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject plateform;
    [SerializeField]
    Transform[] sp;


    // Start is called before the first frame update
    void Start()
    {
        sp = new Transform[transform.childCount];

        for(int i=0; i< transform.childCount; i++)
        {
            sp[i] = transform.GetChild(i);
        }
        
    }

    void Awake(){
        
    }

    void SpawnPlateform()
    {
        int i = Random.Range(0,transform.childCount);
        plateform.transform.position = sp[i].transform.position;
    }

    // Update is called once per frame
     public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Patate");
            SpawnPlateform();
            
        
    }
}
}
