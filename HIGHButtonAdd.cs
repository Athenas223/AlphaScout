using UnityEngine;
using UnityEngine.UI;

public class PointIncrementerHIGHAdd : MonoBehaviour
{
    public Button HIGHButtonAdd;
    public int currentPoints=0;
    public InputField HIGHInput;
    

    private void Start()
    {
        HIGHButtonAdd.onClick.AddListener(IncrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints = (int.Parse(HIGHInput.text));
        currentPoints += 4;
        HIGHInput.text = currentPoints.ToString();
    }
}