using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private GameObject _objectToDisable;

    public void OnButtonClick()
    {
        if (_objectToDisable != null)
            _objectToDisable.SetActive(false);
    }
}
