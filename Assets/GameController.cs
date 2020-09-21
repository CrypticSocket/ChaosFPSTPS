using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;

    public Text ammoText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = player.AmmoRemaining + "/Inf";
    }
}
