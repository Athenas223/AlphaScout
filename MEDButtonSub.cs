using UnityEngine;
using UnityEngine.UI;

public class PointIncrementerMEDSUB : MonoBehaviour
{
    public Button MEDButtonSub;
    public int currentPoints=0;
    public InputField MEDInput;
    

    private void Start()
    {
        MEDButtonSub.onClick.AddListener(DecrementPoints);
    }

    private void DecrementPoints()
    {
        currentPoints = (int.Parse(MEDInput.text));
        currentPoints -= 4;
        MEDInput.text = currentPoints.ToString();
    }
}
