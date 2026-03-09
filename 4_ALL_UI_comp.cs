using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_comp : MonoBehaviour
{
    public float speed = 10f; //image
    public Button b1; //button
    public Toggle toggle; //toggle
    public Slider slider; //slider
    [SerializeField] private TMP_Dropdown m_dropdown; //Dropdown
    public InputField inputField; //InputField
    public TextMeshProUGUI tmpInputField; //TMP InputField
    
    void Start()
    {
        b1.onClick.AddListener(onclick); //button
        toggle.onValueChanged.AddListener(UserValueChanged); //toggle
        slider.onValueChanged.AddListener(SliderValueChanged); //slider
        inputField.onValueChanged.AddListener(InputFieldValueChanged); //InputField
        m_dropdown.onValueChanged.AddListener(DropdownValueChanged); //Dropdown
        tmpInputField.onValueChanged.AddListener(TMPInputFieldValueChanged); //TMP InputField
    }

    //image
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Rotate(0,0,-x*speed*Time.deltaTime);
    }

    //button
    public void onclick()
    {
        Debug.Log("button clicked");
    }

    //toggle
    public void UserValueChanged(bool num)
    {
        Debug.Log("toggle value: " + num);
    }

    //slider
   public void SliderValueChanged(float value)
    {
        string valueStr = value.ToString("F2"); //Format to 2 decimal places,adjust as needed
        Debug.Log("slider value: " + valueStr);
    }

    //Dropdown
    public void DropdownValueChanged(int value)
    {
        int picked = m_dropdown.value;
        string picked_option = m_dropdown.options[picked].text;
        Debug.Log("dropdown value: " + picked_option);
    }

    //InputField
    public void InputFieldValueChanged(string value)
    {
        Debug.Log("input field value: " + value);
    }

    //input field text mesh pro
    public void TMPInputFieldValueChanged(int value)
    {
        if (value == 0)
        {
            output.text = "darpan";
        }
        else if (value == 1)
        {
            output.text = "sahil";
        }
        else if (value == 2)
        {
            output.text = "ronit";
        }
    }
}
