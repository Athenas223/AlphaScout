using UnityEngine;
using UnityEngine.UI;

public class PointIncrementerSMAAdd : MonoBehaviour
{
    public Button SMAButtonAdd;
    public int currentPoints=0;
    public InputField SMAInput;
    

    private void Start()
    {
        SMAButtonAdd.onClick.AddListener(IncrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints = (int.Parse(SMAInput.text));
        currentPoints += 4;
        SMAInput.text = currentPoints.ToString();
    }
}