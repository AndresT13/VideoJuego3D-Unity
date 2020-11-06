using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{
    public float velgiro = 40f;
    public float velup = -40f;




    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {


     //  GetComponent<Transform>().Rotate(0, velgiro * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
       // GetComponent<Transform>().Translate(0,0, velup * Time.deltaTime * Input.GetAxis("Vertical"));
        	if (Input.GetKey (KeyCode.RightArrow)) {//up se mueve al levantar la tecla //si le quito el down va andar seguido, ejemplo (Input.GetKeyDowm (KeyCode.RightArrow))
					transform.Translate (0, 0, -0.1f);
				}
				if (Input.GetKey (KeyCode.LeftArrow)) {//down al preciona//la velocidad la controlan los grados
					transform.Rotate (0, 0,0.1f);
				}
				if (Input.GetKey (KeyCode.UpArrow)) {//getkey sostenida
					transform.Translate (0, 1,0);
				}
				if (Input.GetKey(KeyCode.DownArrow)) {
					transform.Rotate (0,-0.1f , 0);
				}
		



    }
}
