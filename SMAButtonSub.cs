using UnityEngine;
using UnityEngine.UI;

public class PointIncrementerSMASub : MonoBehaviour
{
    public Button SMAButtonSub;
    public int currentPoints=0;
    public InputField SMAInput;
    

    private void Start()
    {
        SMAButtonSub.onClick.AddListener(DecrementPoints);
    }

    private void DecrementPoints()
    {
        currentPoints = (int.Parse(SMAInput.text));
        currentPoints -= 4;
        SMAInput.text = currentPoints.ToString();
    }
}
