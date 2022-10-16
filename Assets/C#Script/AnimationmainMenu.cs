using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationmainMenu : BaseBehaviour
{
	[SerializeField] private Button resButton;
	[SerializeField] private Button templeButton;
	[SerializeField] private Button bankButton;
    [SerializeField] private Button conviButton;
	[SerializeField] private Button shopButton;
	[SerializeField] private Button workButton;
    [SerializeField] private Button houseButton;
	[SerializeField] private Button relaxButton;

    [SerializeField] private Button scoreButton;
	[SerializeField] private Button settingButton;
    [SerializeField] private Button questButton; 

	[SerializeField] private Transform resContainer;
	[SerializeField] private Transform templeContainer;
	[SerializeField] private Transform bankContainer;
	[SerializeField] private Transform conviContainer;
	[SerializeField] private Transform shopContainer;
	[SerializeField] private Transform workContainer;
	[SerializeField] private Transform houseContainer;
	[SerializeField] private Transform relaxContainer;    

	[SerializeField] private Transform scoreContainer;
	[SerializeField] private Transform settingContainer;
	[SerializeField] private Transform questContainer;    

	[SerializeField] private CanvasGroup quest_title;



	private const float INITIAL_DELAY = 1f;
	private const float DELAY_BETWEEN_BUTTONS = 0.3f;

	private List<Button> buttons = new List<Button>();
	private List<Sequence> animationSequences = new List<Sequence>();

	void Start(){
		
	}

	private void Awake()
	{
		resButton?.onClick.AddListener(OnResPressed);
		templeButton?.onClick.AddListener(OnTemplePressed);
        bankButton?.onClick.AddListener(OnBankPressed);
        conviButton?.onClick.AddListener(OnConviPressed);
        shopButton?.onClick.AddListener(OnShopPressed);
        workButton?.onClick.AddListener(OnWorkPressed);
        houseButton?.onClick.AddListener(OnHousePressed);
        relaxButton?.onClick.AddListener(OnRelaxPressed);
        scoreButton?.onClick.AddListener(OnScorePressed);
        settingButton?.onClick.AddListener(OnSettingPressed);
        questButton?.onClick.AddListener(OnQuestPressed);

		buttons.Add(resButton);
		buttons.Add(templeButton);
        buttons.Add(bankButton);
        buttons.Add(conviButton);
        buttons.Add(shopButton);
        buttons.Add(workButton);
        buttons.Add(houseButton);
        buttons.Add(relaxButton);
        buttons.Add(scoreButton);
        buttons.Add(settingButton);
        buttons.Add(questButton);

		AnimateTitle();
		AnimateButtons();
	}

	private void OnDestroy()
	{   resButton?.onClick.RemoveListener(OnResPressed);
		templeButton?.onClick.RemoveListener(OnTemplePressed);
        bankButton?.onClick.RemoveListener(OnBankPressed);
        conviButton?.onClick.RemoveListener(OnConviPressed);
        shopButton?.onClick.RemoveListener(OnShopPressed);
        workButton?.onClick.RemoveListener(OnWorkPressed);
        houseButton?.onClick.RemoveListener(OnHousePressed);
        relaxButton?.onClick.RemoveListener(OnRelaxPressed);
        scoreButton?.onClick.RemoveListener(OnScorePressed);
        settingButton?.onClick.RemoveListener(OnSettingPressed);
        questButton?.onClick.RemoveListener(OnQuestPressed);
		// startButton?.onClick.RemoveListener(OnStartPressed);
		// createButton?.onClick.RemoveListener(OnCreatePressed);

	}

	private void AnimateTitle()
	{
		quest_title.alpha = 0f;
		quest_title.DOFade(1f, 1.8f).SetEase(Ease.InQuint);
	}

	private void AnimateButtons()
	{
		for (int i = 0; i < 100; i++)
		{
			buttons[i].transform.localScale = Vector3.zero;
			AnimateButton(i, INITIAL_DELAY + DELAY_BETWEEN_BUTTONS * i);
		}
	}

	private void AnimateButton(int index, float delay)
	{
		if (animationSequences.Count <= index)
		{
			animationSequences.Add(DOTween.Sequence());
		}
		else
		{
			if (animationSequences[index].IsPlaying())
			{
				animationSequences[index].Kill(true);
			}
		}

		var seq = animationSequences[index];
		var button = buttons[index];

		seq.Append(button.transform.DOScale(1, 0.1f));
		seq.Append(button.transform.DOPunchScale(Vector3.one * 0.6f, 0.8f, 6, 0.7f).SetEase(Ease.OutCirc));
		seq.PrependInterval(delay);
	}

	private void OnResPressed()
	{
	}

	private void OnTemplePressed()
	{
	}

    private void OnBankPressed()
	{
	}

	private void OnConviPressed()
	{
	}

    private void OnShopPressed()
	{
	}

	private void OnWorkPressed()
	{
	}
    private void OnHousePressed()
	{
	}
    private void OnRelaxPressed()
	{
	} 
	private void OnScorePressed()
	{
	}
    private void OnSettingPressed()
	{
	}
    private void OnQuestPressed()
	{
	} 
}
