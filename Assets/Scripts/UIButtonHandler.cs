using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    [SerializeField] private Button OnUIStartButton;
    [SerializeField] private Button OnUIShootButton;
    [SerializeField] private Button OnUIResetButton;

    public static event Action OnUIStartButtonClicked;
    public static event Action OnUIShootButtonClicked;
    public static event Action OnUIResetButtonClicked;

    // Start is called before the first frame update
    void Start()
    {
        OnUIStartButton.onClick.AddListener(OnStartbuttonClicked);
        OnUIShootButton.onClick.AddListener(OnShootbuttonClicked);
        OnUIResetButton.onClick.AddListener(OnResetbuttonClicked);

        OnUIShootButton.gameObject.SetActive(false);
    }

    void OnStartbuttonClicked()
    {
        OnUIStartButtonClicked?.Invoke();
        OnUIStartButton.gameObject.SetActive(false);
        OnUIShootButton.gameObject.SetActive(true);
    }

    void OnShootbuttonClicked()
    {
        OnUIShootButtonClicked?.Invoke();
    }

    void OnResetbuttonClicked()
    {
        OnUIResetButtonClicked?.Invoke();
        OnUIStartButton.gameObject.SetActive(true);
        OnUIShootButton.gameObject.SetActive(false);
    }
}
