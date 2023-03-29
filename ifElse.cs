using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ifElse : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro; 
    public int kredit = 30000;
    public float zinsen = 0.5F;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void whatelse()
    {

        if (zinsen < 3.0)
        {
            textMeshPro.text = $"Ich nehme dieses Angebot gerne an!";
        }
        else 
       {
           textMeshPro.text = $"Nope zu teuer.";
       }

    }
}
