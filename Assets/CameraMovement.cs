using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public int speed;
    void Update(){
        if(Input.GetKey(KeyCode.RightArrow) & transform.position.x < 16){ 
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
        }
        if(Input.GetKey(KeyCode.LeftArrow) & transform.position.x > -16){
            transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
        }
		
    }
}
