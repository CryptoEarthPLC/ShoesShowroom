using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShoesMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _description;
    [SerializeField] private GameObject _colorsMode;
    
    public void BackToMenu()
    {
        _description.SetActive(false);
        _colorsMode.SetActive(false);
        _mainMenu.SetActive(true);
    }

    public void Description()
    {
        _mainMenu.SetActive(false);
        _description.SetActive(true);
    }

    public void Colors()
    {
        _mainMenu.SetActive(false);
        _colorsMode.SetActive(true);
    }
}
