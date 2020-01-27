using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenSprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake(){
         changeToCamScale();
    }
	 
	void changeToCamScale(){
		Vector3 k = transform.localScale;
		k.x = 2 * Camera.main.orthographicSize * Camera.main.aspect / GetComponent<SpriteRenderer>().sprite.bounds.size.x;
		k.y = 2 * Camera.main.orthographicSize / GetComponent<SpriteRenderer>().sprite.bounds.size.y;
		transform.localScale = k;
	}
}
