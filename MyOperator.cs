using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyOperator : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //code to response when button is pressed
    public void DisplayMessage()
    {
        int xp = 990;
        xp += 10;
        xp -= 10;
        xp *= 10;
        xp /= 10;

        int strength = 18;
        int stat = strength++;
        //Tipp:careful with postfix operator: only gets executed after one other execution, can create misunderstandings--better do it with += and * operator: stat = 2 * strength; strength += 1;
        //int joyDivision = 5 / 2;
        int joyDivision = 5 % 2;//returns remainder of the division operation before, can determin whether a number is even or not
        string firstName = "Vegetarian";
        string lastName = "Zombie";
        string fullName = firstName + " " + lastName; 

        int problem = 3 - (3 * 6) + 2;  
        //simplicity over complexity: can also use parantathese to make sure that int in these get calculated first
        //convert type to another type:
        float conversion = (float) 100;
        int largeNumber = 1_000_000;
        byte smallNumber = (byte) largeNumber;
 
        textMeshPro.text = $"{smallNumber}";   

    }
}
