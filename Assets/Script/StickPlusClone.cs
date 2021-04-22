using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPlusClone : MonoBehaviour
{
    Vector2 temp;
    public int compteur = 0;
   public bool status = true;
   public bool stopStick = false;
   public int Speed = 2;
    Rigidbody2D m_rb2D2;
    SpriteRenderer m_renderer;

    public StickPlusClone MyStickPlus;

void Start(){
    compteur = 0;
    stopStick = false;
    Speed = 1;
    

}
void Awake()
{
    m_rb2D2 = gameObject.GetComponent<Rigidbody2D>();
    m_renderer = gameObject.GetComponent<SpriteRenderer>();
    MyStickPlus = GetComponent<StickPlusClone>();
    
}
void Update(){
if (Input.GetKeyDown(KeyCode.A))
{
stopStick = true;
}


if(stopStick == true)
{
    RotationDuStick();
    return;
}

else if (stopStick == false){
    
}

    if(compteur == 0)
    {
    print(compteur);
    status = false;
    }

    else if (compteur == 580)
    {
    print(compteur);
    status = true;
    }

    if (status == true)
    {
    temp = transform.localScale;
    temp.y -= Time.deltaTime;
    transform.localScale = temp;
    compteur--;
    }

    else if (status == false)
    {
    temp = transform.localScale;
    temp.y += Time.deltaTime;
    transform.localScale = temp;
    compteur++;

   /* float smooth = 5.0f;
    float tiltAngle = 90.0f;

    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetKeyDown(KeyCode.A) * tiltAngle;


        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
    }*/
    }

}
    void RotationDuStick(){
        transform.Rotate(Vector3.back * Speed);
    
    
    }
}


