using UnityEngine;
using UnityEngine.UI;

public class PointIncrementerMEDadd : MonoBehaviour
{
    public Button MEDButton;
    public int currentPoints=0;
    public InputField MEDInput;
    

    private void Start()
    {
        MEDButton.onClick.AddListener(IncrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints = (int.Parse(MEDInput.text));
        currentPoints += 4;
        MEDInput.text = currentPoints.ToString();
    }
}