using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Ghost : MonoBehaviour
{
	
	public float timeLeft;
	public Sprite angrySprite;
    public Sprite veryAngrySprite; 
    public Sprite furiousSprite; 
	public Sprite color1; 
	public Sprite color2; 
	public Sprite color3;
	public Sprite color4; 
	public Sprite color5;
	public Sprite color6; 
	private Sprite[] colors;
	public int[] lista;
	private Inventory inventory;
	
    void Start()
    {
		inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
		lista = new int[4];
		colors = new Sprite[6];
		colors[0] = color1; 
		colors[1] = color2;
		colors[2] = color3; 
		colors[3] = color4; 
		colors[4] = color5; 
		colors[5] = color6; 
		for(int i = 0; i < 4; i++){
			lista[i] = Random.Range(1,6);
		}
		this.GetComponent<Image>().sprite = colors[lista[0]];
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
		
		
		if ( timeLeft < 0 )
		{
			SceneManager.LoadScene("GameOver");
		}
		else if (timeLeft < 5 )
		{
			this.GetComponent<Image>().sprite = angrySprite;
		}
		else if (timeLeft < 15 )
		{
			this.GetComponent<Image>().sprite = veryAngrySprite;
		}
		else if (timeLeft < 35)
		{
			this.GetComponent<Image>().sprite = furiousSprite;
		}
		else if(timeLeft < 43){
			this.GetComponent<Image>().sprite = angrySprite;
		}
		else if(timeLeft < 44){
			this.GetComponent<Image>().sprite = colors[lista[3]];
		}
		else if(timeLeft < 45){
			this.GetComponent<Image>().sprite = angrySprite;
		}
		else if(timeLeft < 46){
			this.GetComponent<Image>().sprite = colors[lista[2]];
		}
		else if(timeLeft < 47){
			this.GetComponent<Image>().sprite = angrySprite;
		}
		else if(timeLeft < 48){
			this.GetComponent<Image>().sprite = colors[lista[1]];
		}
		else if(timeLeft < 49){
			this.GetComponent<Image>().sprite = angrySprite;
		}
		
		
    }
	
	public void Venta(){
		for(int i = 0; i < 4; i++){
			string palabra = "obj" + lista[i].ToString() + " (clone)";
			if(!(GameObject.Find (palabra))){
				SceneManager.LoadScene("GameOver");
			}
		}
		SceneManager.LoadScene("Victory");
	}
	
	
}
