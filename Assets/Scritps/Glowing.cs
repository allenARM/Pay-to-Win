using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glowing : MonoBehaviour
{
	public float ColorDarkness = 160.0f;
	public float color_rate = 0.001f; 
	Light lt;
	public int direction = 0;
	public bool horizontal_dir = true;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
		lt.color = new Color(ColorDarkness/255.0f, 255.0f/255.0f, ColorDarkness/255.0f, 1);
	}

    // Update is called once per frame
	// Code in FixedUpdate is just a color changer of background in the game <3
	// I just wasnt able to find it on internet, so I made a new one.
    void FixedUpdate()
    {
		if (direction == 0)
		{
			if (horizontal_dir == true)
			{
				lt.color = new Color(lt.color.r + color_rate, lt.color.g, lt.color.b, 1);
			}
			else
			{
				lt.color = new Color(lt.color.r - color_rate, lt.color.g, lt.color.b, 1);
			}
			if (lt.color.r <= ColorDarkness/255.0f || lt.color.r >= 254.0f/255.0f)
			{
				direction = 1;
				horizontal_dir = !horizontal_dir;
			}
		}
		else if (direction == 1)
		{
			if (horizontal_dir == true)
			{
				lt.color = new Color(lt.color.r, lt.color.g + color_rate, lt.color.b, 1);
			}
			else
			{
				lt.color = new Color(lt.color.r, lt.color.g - color_rate, lt.color.b, 1);
			}
			if (lt.color.g <= ColorDarkness/255.0f || lt.color.g >= 254.0f/255.0f)
			{
				direction = 2;
				horizontal_dir = !horizontal_dir;
			}
		}
		else if (direction == 2)
		{
			if (horizontal_dir == true)
			{
				lt.color = new Color(lt.color.r, lt.color.g, lt.color.b + color_rate, 1);
			}
			else
			{
				lt.color = new Color(lt.color.r, lt.color.g, lt.color.b - color_rate, 1);
			}
			if (lt.color.b <= ColorDarkness/255.0f || lt.color.b >= 254.0f/255.0f)
			{
				direction = 0;
				horizontal_dir = !horizontal_dir;
			}
		}
    }
}
