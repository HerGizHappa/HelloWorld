using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MadLips : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    public bool statement;
    public string verb, noun, adjective;
    public int number;
    public string pluralNoun = "elves";
    public float percent = 60.6F;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The 'is' statement is {statement}. I did not {verb} the {noun}. I am not guily. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sure of this."; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
