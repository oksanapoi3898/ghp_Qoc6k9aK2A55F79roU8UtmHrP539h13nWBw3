using UnityEngine;
using UnityEngine.UI;

public class _0x5cfffc09 : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3fe52430.Instance._0xe43ad4df(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xc4913dd8.Instance._0x0aa59b50());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3fe52430.Instance._0xe43ad4df(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x3fe52430.Instance._0xe43ad4df(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xc4913dd8.Instance._0x0aa59b50());
        }
    }

    public bool IsTutorialEndPanel;
}