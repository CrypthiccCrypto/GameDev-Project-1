using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    void Start() {
        transform.position = new Vector2(PlayerPrefs.GetInt("HighScore", 0)/10, 0); // Initially out of sight
        if (PlayerPrefs.GetInt("HighScore", 0) == 0) transform.position = new Vector2(-100, 0);
    }
    
    public void placeHighScore(float x, float y) { //Place sign showing high score at the new ball position
        transform.position = new Vector2(x, y);
    }
}
