using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : BaseBehaviour
{
	[SerializeField] private Button startButton;
	[SerializeField] private Button createButton;


	[SerializeField] private Transform startContainer;
	[SerializeField] private Transform createContainer;


	[SerializeField] private CanvasGroup title;

	private const float INITIAL_DELAY = 1f;
	private const float DELAY_BETWEEN_BUTTONS = 0.3f;

	private List<Button> buttons = new List<Button>();
	private List<Sequence> animationSequences = new List<Sequence>();

	void Start(){
		
	}

	private void Awake()
	{
		startButton?.onClick.AddListener(OnStartPressed);
		createButton?.onClick.AddListener(OnCreatePressed);


		buttons.Add(startButton);
		buttons.Add(createButton);


		AnimateTitle();
		AnimateButtons();
	}

	private void OnDestroy()
	{
		startButton?.onClick.RemoveListener(OnStartPressed);
		createButton?.onClick.RemoveListener(OnCreatePressed);

	}

	private void AnimateTitle()
	{
		title.alpha = 0f;
		title.DOFade(1f, 1.8f).SetEase(Ease.InQuint);
	}

	private void AnimateButtons()
	{
		for (int i = 0; i < 4; i++)
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

	private void OnCreatePressed()
	{
	}

	private void OnStartPressed()
	{
	}
}
