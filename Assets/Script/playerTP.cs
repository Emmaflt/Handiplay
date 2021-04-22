using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTP : MonoBehaviour
{
    public GameObject plateform;
    [SerializeField]
    Transform[] sp;
    public GameObject Stick; 
    public Component ScriptStick;

    public Vector2 scaleChange;
    public Vector3 rotateChange;
    public int Speed = 10;
    public bool status = true;

    public GameObject prefabStick;
    private Vector3 StickClone;
    public Component MonScript;

    // Start is called before the first frame update
    public void Start()
    {
        StickClone = new Vector3(-3.61f, -2.21f, 1f);
        MonScript = Resources.Load("StickPlusClone") as Component;
    }

    public void SpawnPlateform()
    {
        plateform.transform.position = sp[0].transform.position;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            status = false;
            SpawnPlateform();
            Stick.transform.Rotate(Vector3.down * Speed);
            Destroy(GameObject.FindGameObjectWithTag("Stick"));
            Destroy(GameObject.FindGameObjectWithTag("PrefabStick"));
            GameObject a = Instantiate(prefabStick) as GameObject;
            a.transform.position = new Vector3(-3.61f, -2.21f, -1f);
            a.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
