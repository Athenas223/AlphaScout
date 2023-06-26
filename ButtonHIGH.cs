using UnityEngine;
using UnityEngine.UI;

public class PointIncrementer : MonoBehaviour
{
    public Button ButtonHIGH;
    public InputField HIGHInput;
    private int currentPoints;

    private void Start()
    {
        currentPoints = 0;
        ButtonHIGH.onClick.AddListener(IncrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints += 5;
        HIGHInput.text = currentPoints.ToString();
    }
}

