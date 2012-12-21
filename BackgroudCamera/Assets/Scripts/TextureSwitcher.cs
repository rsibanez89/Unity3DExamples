using UnityEngine;
using System.Collections;

public class TextureSwitcher : MonoBehaviour
{
	public GUITexture background;
	public Texture2D[] texturas;
	private int textureToDraw;
	
	// Use this for initialization
	void Start ()
	{
		texturas = new Texture2D[2];
		texturas[0] = (Texture2D)Resources.Load("Backgrounds/bg", typeof(Texture2D));
		texturas[1] = (Texture2D)Resources.Load("Backgrounds/bg2", typeof(Texture2D));
		textureToDraw = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		background.pixelInset = new Rect(-Screen.width/2, -Screen.height/2, Screen.width, Screen.height);
		background.texture = texturas[textureToDraw];
		if(Input.GetKeyDown(KeyCode.LeftArrow))
			textureToDraw = 0;
		if(Input.GetKeyDown(KeyCode.RightArrow))
			textureToDraw = 1;
	}
}
