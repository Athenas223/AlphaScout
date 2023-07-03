using UnityEngine;
using UnityEngine.UI;

public class PointIncrementerHIGHSub : MonoBehaviour
{
    public Button HIGHButtonSub;
    public int currentPoints=0;
    public InputField HIGHInput;
    

    private void Start()
    {
        HIGHButtonSub.onClick.AddListener(DecrementPoints);
    }

    private void DecrementPoints()
    {
        currentPoints = (int.Parse(HIGHInput.text));
        currentPoints -= 4;
        HIGHInput.text = currentPoints.ToString();
    }
}

