using UnityEngine;
using UnityEngine.UI;

public class RandomStringField : IButton
{
    private RandomString randomString;
    private InputField _inputField;

    public RandomStringField(InputField inputField, string path)
    {
        _inputField = inputField;
        randomString = new RandomString(path);
    }

    public void Click()
    {
        
        _inputField.text = randomString.Activate();
    }

    public void Hold()
    {
        //When holding down, click will just be constantly called
        Click();
    }
    public void Release()
    {
        //Nothing
    }
}
