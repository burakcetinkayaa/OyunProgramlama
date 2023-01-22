using UnityEngine;
using UnityEngine.UI;

public class unlock : MonoBehaviour
{
    public int totalMetalCollected = 0;

    public bool carUnlocked;
    public bool trainUnlocked;
    
    public Text targetText;
    public string newText = "NULL";


    void Update()   
    {
      if (totalMetalCollected >= 10)
        {
            carUnlocked = true;
        }
      if (totalMetalCollected >= 50)
        {
            trainUnlocked= true;
        }

        newText = totalMetalCollected.ToString();

        targetText.text = newText;
    }
}
